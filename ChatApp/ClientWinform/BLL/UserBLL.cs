﻿using ClientWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWinform.Helpers;

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
        public static List<User> getUserListChat(int idUser)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                List<User> users = new List<User>();
                var li = db.Users.Where(record => record.Id != idUser && record.IdRole == Constants.Roles.USER);
                users.AddRange(li); 
                return users;
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
                //User updateUser = db.Users.Where(record => record.Id == user.Id).FirstOrDefault();
                //updateUser.IdAvatar = ava.Id;
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

    }
}
