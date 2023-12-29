using ClientWinform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.BLL
{
    internal class FileBLL
    {
        public static int InsertFile(int idFrom, string name, string path)
        {
            using (testpbldbEntities1 db = new testpbldbEntities1())
            {
                DTO.File file = new DTO.File()
                {
                    Name = name,
                    Path = path,
                    Status = Constants.Statuses.ACTIVE,
                    CreatedDate = DateTime.Now,
                    CreatedBy = idFrom,
                };

                db.Files.Add(file);
                db.SaveChanges();
                return file.Id;
            }
        }

        public static DTO.File getFileNameByIdMsg(int idMsg)
        {
            try
            {
                using (testpbldbEntities1 db = new testpbldbEntities1())
                {
                    Message message = db.Messages.Where(x => x.Id == idMsg && x.Status != Constants.MessageStatuses.INACTIVE).FirstOrDefault();
                    if (message == null) throw new Exception("Message Not Found.");
                    else if (message.IdFile != null && message.IdFile != 0)
                    {
                        DTO.File file = db.Files.Where(x => x.Id == message.IdFile && x.Status == Constants.Statuses.ACTIVE).FirstOrDefault();
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
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
