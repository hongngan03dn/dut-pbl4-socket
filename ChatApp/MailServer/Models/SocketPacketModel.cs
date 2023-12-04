using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer.Models
{
    public class SocketPacketModel
    {
        public int IdFrom { get; set; }
        public int IdTo { get; set; }
        public String ContentMsg { get; set; }

        public SocketPacketModel() { }
        public SocketPacketModel(int fromId, int toId, string contentMsg)
        {
            IdFrom = fromId;
            IdTo = toId;
            ContentMsg = contentMsg;
        }
    }
}
