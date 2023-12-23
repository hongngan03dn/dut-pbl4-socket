using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.DTO
{
    public class SocketPacketModel
    {
        public int IdMsg { get; set; }
        public int IdFrom {  get; set; }
        public int IdTo { get; set; }
        public String ContentMsg { get; set; }

        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int PacketType { get; set; }
        public byte[] SubPacketFile { get; set; } = new byte[1024 * 128]; // 128KB

        public SocketPacketModel() 
        {
            PacketType = Constants.PacketType.MESSAGE;
        }
        public SocketPacketModel(int idMsg, int fromId, int toId, string contentMsg, Nullable<DateTime> createdDate, int packetType = Constants.PacketType.MESSAGE)
        {
            IdMsg = idMsg;
            IdFrom = fromId;
            IdTo = toId;
            ContentMsg = contentMsg;
            CreatedDate = createdDate;
            PacketType = packetType;
        }
    }
}
