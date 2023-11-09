using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MailServer
{
    public class ClientModel
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public Socket clientSocket { get; set; }
    }
}
