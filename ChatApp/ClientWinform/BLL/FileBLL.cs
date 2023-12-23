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
    }
}
