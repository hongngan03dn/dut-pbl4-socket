using MailServer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.DBHelpers
{
    public class MessageHelper
    {
        private static readonly testpbldbContext _context = new testpbldbContext();

        public void InsertMessage(int idFrom, int idTo, String contentMsg, int status)
        {
            try
            {
                Message msg = new Message();
                msg.IdFrom = idFrom;
                msg.IdTo = idTo;
                msg.ContentMsg = contentMsg;
                msg.Status = status;
                msg.CreatedBy = idFrom;
                msg.CreatedDate = DateTime.Now;

                _context.Messages.Add(msg);

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
