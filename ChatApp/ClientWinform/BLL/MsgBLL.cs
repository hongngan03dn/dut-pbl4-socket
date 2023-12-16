using ClientWinform.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.BLL
{
    internal class MsgBLL
    {

        public static List<UserModel> getUserListChat(int id)
        {
            using (var context = new testpbldbEntities1())
            {
                var users = context.Users
                                   .Where(u => u.Id != id)
                                   .Join(context.Messages,
                                         u => u.Id,
                                         m => m.IdFrom == id ? m.IdTo : (m.IdTo == id ? m.IdFrom : -1),
                                         (u, m) => new { User = u, Message = m })
                                   .Where(um => (((um.Message.IdFrom == id || um.Message.IdTo == id) && um.Message.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD)
                                               || ((um.Message.IdFrom == id || um.Message.IdTo == id) && um.Message.Description == Constants.ConnectionsDescr.CONNECTIONKEYWORD && um.Message.Status == Constants.ConnectionsDescr.CONNECTED)))
                                   .GroupBy(um => new { um.User.Id, um.User.Username, um.User.IdAvatar })
                                   .Select(g => new UserModel
                                   {
                                       Id = g.Key.Id,
                                       Username = g.Key.Username,
                                       IdAvatar = g.Key.IdAvatar,
                                       LatestMessageTime = g.Max(um => um.Message.CreatedDate)
                                   })
                                   .OrderByDescending(u => u.LatestMessageTime)
                                   .ToList();

                return users;
            }
        }
        public static List<UserModel> getUserConnection(int id)
        {
            using (var context = new testpbldbEntities1())
            {
                var users = context.Users
                                   .Where(u => u.Id != id)
                                   .Join(context.Messages,
                                         u => u.Id,
                                         m => m.IdFrom == id ? m.IdTo : (m.IdTo == id ? m.IdFrom : -1),
                                         (u, m) => new { User = u, Message = m })
                                   .Where(um => (um.Message.IdFrom == id || um.Message.IdTo == id) && um.Message.Description == Constants.ConnectionsDescr.CONNECTIONKEYWORD)
                                   .GroupBy(um => new { um.User.Id, um.User.Username, um.User.IdAvatar })
                                   .Select(g => new UserModel
                                   {
                                       Id = g.Key.Id,
                                       Username = g.Key.Username,
                                       IdAvatar = g.Key.IdAvatar,
                                       LatestMessageTime = g.Max(um => um.Message.CreatedDate)
                                   })
                                   .OrderByDescending(u => u.LatestMessageTime)
                                   .ToList();

                return users;
            }
        }
        public static DTO.Message getMessage(int idFrom, int idTo)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var msg = db.Messages.Where(record => ((record.IdFrom == idFrom && record.IdTo == idTo) ||
                                                      (record.IdFrom == idTo && record.IdTo == idFrom))
                                                      && record.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD)
                                        .OrderByDescending(record => record.CreatedDate)
                                        .FirstOrDefault();
                return msg;
            }
        }
        public static DTO.Message getMessageById(int id)
        {
            using (var context = new testpbldbEntities1())
            {
                var acc = context.Messages
                                 .Where(msg => msg.Id == id)
                                 .FirstOrDefault();
                return acc;
            }
        }
        public static bool checkMsgUnread(int idTo, int idFrom)
        {
            using(testpbldbEntities1 db = new testpbldbEntities1())
            {
                var msg = db.Messages.Where(record => record.IdTo == idTo && record.IdFrom == idFrom 
                                                   && record.Status == Constants.MessageStatuses.RECEIVED
                                                   && record.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD).Count();
                if (msg > 0)
                    return true;
                else
                    return false;
            }
        }
        public static void LoadMsgesToReceived(int idTo)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var msgLi = db.Messages.Where(record => record.IdTo == idTo && record.Status == Constants.MessageStatuses.SENT && record.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD).ToList();

                msgLi.ForEach(msg => { msg.Status = Constants.MessageStatuses.RECEIVED;
                                       msg.UpdatedDate = DateTime.Now;}) ;

                db.SaveChanges();
            }
        }
        public static void LoadMsgesToSeen(int idTo, int idFrom)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var msgLi = db.Messages.Where(record => record.IdTo == idTo && record.IdFrom == idFrom 
                                                     && record.Status == Constants.MessageStatuses.RECEIVED 
                                                     && record.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD).ToList();

                msgLi.ForEach(msg => {
                    msg.Status = Constants.MessageStatuses.SEEN;
                    msg.UpdatedDate = DateTime.Now;
                });

                db.SaveChanges();
            }
        }
        public static void UpdateMsgesToSeen(int idMsg)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                Message message = db.Messages.Where(msg => msg.Id == idMsg).FirstOrDefault();
                message.Status = Constants.MessageStatuses.SEEN;
                message.UpdatedDate = DateTime.Now;
                db.SaveChanges();
            }
        }
        public static int InsertMessage(int idFrom, int idTo, String contentMsg)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                DTO.Message msg = new DTO.Message()
                {
                    IdFrom = idFrom,
                    IdTo = idTo,
                    ContentMsg = contentMsg,
                    Status = Constants.MessageStatuses.SENT,
                    CreatedDate = DateTime.Now,
                    CreatedBy = idFrom,
                };
                db.Messages.Add(msg);
                db.SaveChanges();
                return msg.Id;
            }
        }
        public static List<DTO.Message> GetTopMessages(int idFrom, int idTo, int skipCount)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                var msg = db.Messages.Where(record => ((record.IdFrom == idFrom && record.IdTo == idTo) ||
                                                       (record.IdFrom == idTo && record.IdTo == idFrom))
                                                     && record.Description != Constants.ConnectionsDescr.CONNECTIONKEYWORD)
                                     .OrderByDescending(record => record.CreatedDate)
                                     .Skip(skipCount).Take(50).ToList();
                return msg;
            }
        }
        public static int getWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public static string formatTime(Nullable<System.DateTime> time)
        {
            string chatTime = "";
            if (time.Value.Date == DateTime.Now.Date)
            {
                chatTime = time.Value.ToString("hh:mm tt");
            }
            else if (getWeekOfYear(time.Value) == getWeekOfYear(DateTime.Now))
            {
                chatTime = time.Value.ToString("ddd");
            }
            else if(time.Value.Year == DateTime.Now.Year)
            {
                chatTime = time.Value.ToString("MMM dd");
            }
            else
            {
                chatTime = time.Value.ToString("MMM dd, yyyy");
            }
            return chatTime;
        }
        public static string formatTimeInChatContent(Nullable<System.DateTime> time)
        {
            string chatTime = "";
            if(time != null)
            {
                if (time.Value.Date == DateTime.Now.Date)
                {
                    chatTime = time.Value.ToString("hh:mm tt");
                }
                else if (time.Value.Year == DateTime.Now.Year)
                {
                    chatTime = time.Value.ToString("dd/MM hh:mm tt");
                }
                else
                {
                    chatTime = time.Value.ToString("dd/MM/yy hh:mm tt");
                }
            }
            return chatTime;
        }

    }
}
