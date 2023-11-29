using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.DTO
{
    public class SocketPacketModel
    {
        public int FromId {  get; set; }
        public int ToId { get; set; }
        public String ContentMsg { get; set; }

        public SocketPacketModel() { }
        public SocketPacketModel(int fromId, int toId, string contentMsg)
        {
            FromId = fromId;
            ToId = toId;
            ContentMsg = contentMsg;
        }
    }
}
