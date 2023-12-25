using ClientWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWinform.Helpers;
using static Guna.UI2.Native.WinApi;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Cryptography;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClientWinform.BLL
{
    internal class UserBLL
    {
        public static void SignUp(User user)
        {
            if (IsExistedEmail(user.Email))
            {
                throw new Exception("Email is already existed.");
            }
            if (IsExistedUsername(user.Username))
            {
                throw new Exception("Username is already existed.");
            }
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                user.Password = MD5Hasher.ToMD5(user.Password);
                testpbldb.Users.Add(user);
                testpbldb.SaveChanges();
            }
        }
        public static Boolean IsExistedEmail(String email)
        {
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Email == email && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                if (user != null)
                {
                    return true;
                }
                return false;
            }
        }
        public static Boolean IsExistedUsername(String username)
        {
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Username == username && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                if (user != null)
                {
                    return true;
                }
                return false;
            }
        }
        public static int SignIn(String username, String password)
        {
            password = MD5Hasher.ToMD5(password);
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Username == username && x.Password == password && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                if (user != null)
                {
                    return user.Id;
                }
                return 0;
            }
        }
        public static int getRole(int id)
        {
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Id == id && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                if (user != null)
                {
                    if (user.IdRole == null) throw new Exception("Missing Role Authorization.");
                    return (int)user.IdRole;
                }
                return 0;
            }
        }
        public static User getUserByID(int id)
        {
            using (var context = new testpbldbEntities1())
            {
                var acc = context.Users
                                 .Where(user => user.Id == id)
                                 .FirstOrDefault();
                return acc;
            }
        }
        public static List<string> checkExistedEmail(string email)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                List<string> gmails = new List<string>();
                var li = db.Users.Where(record => record.Email != email && record.IdRole == Constants.Roles.USER)
                                 .Select(records => records.Email);
                gmails.AddRange(li);
                return gmails;
            }
        }
        public static List<string> checkExistedUsername(string username)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                List<string> usernames = new List<string>();
                var li = db.Users.Where(record => record.Username != username && record.IdRole  == Constants.Roles.USER)
                                 .Select(records => records.Username);
                usernames.AddRange(li);
                return usernames;
            }
        }

        public static void updateUser(User user)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                User updateUser = db.Users.Where(record => record.Id == user.Id).FirstOrDefault();
                updateUser.Name = user.Name;
                updateUser.IdAvatar = user.IdAvatar;
                updateUser.Username = user.Username;
                updateUser.Email = user.Email;
                updateUser.Gender = user.Gender;
                updateUser.BOD = user.BOD;
                updateUser.Bio = user.Bio;
                updateUser.UpdatedDate = DateTime.Now;
                updateUser.UpdatedBy = user.Id;
                db.SaveChanges();

            }
        }
        public static int getNewestIDAva()
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                var newestId = db.Avatars.OrderByDescending(record => record.Id)
                                         .Select(record => record.Id);
                return newestId.FirstOrDefault() + 1;
            }
        }
        public static int changeAva(byte[] images, User user)
        {
            Avatar ava = new Avatar();
            ava.Id = getNewestIDAva();
            ava.AvaImg = @images;
            ava.Status = Constants.Statuses.ACTIVE;
            ava.CreatedDate = DateTime.Now;
            ava.CreatedBy = user.Id;
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                db.Avatars.Add(ava);
                db.SaveChanges();
            }
            return ava.Id;
        }
        public static byte[] getAvaLinkById(Nullable<System.Int32> id)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                var avaLink = db.Avatars.Where(record => record.Id == id && record.Status == Constants.Statuses.ACTIVE)
                                        .Select(record => record.AvaImg).FirstOrDefault();
                return avaLink;
            }
        }

        public static void resetPassword(string email)
        {
            string newPw = MailUtils.SendResetPassword(email);
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Email == email && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                if (user != null)
                {
                    user.Password = MD5Hasher.ToMD5(newPw);
                    user.UpdatedDate = DateTime.Now;
                    testpbldb.SaveChanges();
                }
            }
        }
        public static List<User> getConnectingOfUser(int idFrom, string txtSearch)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var connections = db.Messages.Where(record => ((record.IdFrom == idFrom || record.IdTo == idFrom))
                                                 && record.Description == Constants.ConnectionsDescr.CONNECTIONKEYWORD && record.Status == Constants.ConnectionsDescr.CONNECTING).ToList();
                List<User> users = new List<User>();
                User user = null;
                foreach (DTO.Message connection in connections)
                {
                    user = new User();
                    if (connection.IdFrom == idFrom)
                        user = BLL.UserBLL.getUserByID((int)connection.IdTo);
                    else
                        user = BLL.UserBLL.getUserByID((int)connection.IdFrom);
                    users.Add(user);
                }
                return users.OrderBy(record => record.Username).Where(record => record.Username.Contains(txtSearch)).ToList();
            }
        }
        public static List<User> GetUserExplore(int idFrom, List<int> idUserExcept, List<User> connectingList, string txtSearch)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                List<User> getUserExplore = new List<User>();
                var userTemp = db.Users.Where(record => record.Id != idFrom && record.IdRole == Constants.Roles.USER).ToList();
                foreach(int idExcept in idUserExcept)
                {
                    var userExplore = db.Users.Where(record => record.Id == idExcept).FirstOrDefault();
                    userTemp.Remove(userExplore);
                }
                foreach(User connecting in connectingList)
                {
                    var userConnecting = db.Users.Where(record => record.Id == connecting.Id).FirstOrDefault();
                    userTemp.Remove(userConnecting);
                }
                getUserExplore = userTemp.ToList();
                return getUserExplore.OrderBy(record => record.Username).Where(record => record.Username.Contains(txtSearch)).ToList();
            }
        }
        public static int getConnectionsOfUser(int userId)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                var numConnections = db.Messages.Where(record => (record.IdFrom == userId || record.IdTo == userId) && record.Description == Constants.ConnectionsDescr.CONNECTIONKEYWORD).Count();
                return numConnections;
            }
        }

        public static DTO.Message checkIsHaveConnection(int userId, int connectionId)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var check = db.Messages.Where(record => ((record.IdFrom == userId && record.IdTo == connectionId) ||
                                                         (record.IdFrom == connectionId && record.IdTo == userId))
                                                       && record.Description == Constants.ConnectionsDescr.CONNECTIONKEYWORD).OrderByDescending(record => record.CreatedDate).FirstOrDefault();
                return check;
            }
        }

        public static void InsertConnection(int userId, int connectionId)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                DTO.Message connection = new DTO.Message()
                {
                    IdFrom = userId,
                    IdTo = connectionId,
                    Status = Constants.ConnectionsDescr.CONNECTING,
                    Description = Constants.ConnectionsDescr.CONNECTIONKEYWORD,
                    CreatedBy = userId,
                    CreatedDate = DateTime.Now,
                };
                db.Messages.Add(connection);
                db.SaveChanges();
            }
        }
        public static void UpdateConnectionToConnected(int idConnection, int idUser)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                DTO.Message connection = db.Messages.Where(record => record.Id == idConnection).FirstOrDefault();
                connection.Status = Constants.ConnectionsDescr.CONNECTED;
                connection.UpdatedDate = DateTime.Now;
                connection.UpdatedBy = idUser;
                db.SaveChanges();
            }
        }
        public static void UpdateConnectionToDisConnect(int idConnection, int idUser)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                DTO.Message connection = db.Messages.Where(record => record.Id == idConnection).FirstOrDefault();
                connection.Status = Constants.ConnectionsDescr.NOTCONNECT;
                connection.UpdatedDate = DateTime.Now;
                connection.UpdatedBy = idUser;
                db.SaveChanges();
            }
        }

        public static void changePassword(int idUser, string newPassword, string currentPassword)
        {
            currentPassword = MD5Hasher.ToMD5(currentPassword);
            using (testpbldbEntities1 testpbldb = new testpbldbEntities1())
            {
                var user = testpbldb.Users.Where(x => x.Id == idUser && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                
                if (user == null) throw new Exception("User not found");
                if (!user.Password.Equals(currentPassword)) throw new Exception("Current Password is wrong");

                user.Password = MD5Hasher.ToMD5(newPassword);
                user.UpdatedDate = DateTime.Now;
                testpbldb.SaveChanges();
            }
        }
    }
}
