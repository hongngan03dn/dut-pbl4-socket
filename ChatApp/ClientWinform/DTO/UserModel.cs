using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.DTO
{
    internal class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? IdAvatar { get; set; }
        public System.DateTime? LatestMessageTime { get; set; }
        public int? Status { get; set; }
    }
}
