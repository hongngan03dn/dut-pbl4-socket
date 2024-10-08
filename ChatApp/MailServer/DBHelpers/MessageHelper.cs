﻿using MailServer.Entities;
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
        public void UpdateMesageToReceived(int idMsg)
        {
            try
            {
                Message msg = _context.Messages.Where(msg => msg.Id == idMsg).FirstOrDefault();
                msg.Status = Constants.MessageStatuses.RECEIVED;
                msg.UpdatedDate = DateTime.Now;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Entities.File getFileNameByIdMsg(int idMsg)
        {
            try
            {
                Message message =_context.Messages.Where(x => x.Id == idMsg && x.Status != Constants.MessageStatuses.INACTIVE).FirstOrDefault();
                if (message == null) throw new Exception("Message Not Found.");
                else if (message.IdFile != null && message.IdFile != 0)
                {
                    Entities.File file = _context.Files.Where(x => x.Id == message.IdFile && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
                    if (file == null)
                        throw new Exception("File Not Found in DB");
                    else
                        return file;
                }
                else
                {
                    throw new Exception("This message does not contain File.");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
