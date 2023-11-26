using ClientWinform.DTO;
using System;
using System.Collections.Generic;
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
