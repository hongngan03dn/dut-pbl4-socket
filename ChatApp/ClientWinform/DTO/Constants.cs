using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinform.DTO
{
    public class Constants
    {
        public static class Statuses
        {
            public const int ACTIVE = 1;
            public const int INACTIVE = 0;
        }
        public static class Roles
        {
            public const int ADMIN = 1;
            public const int USER = 2;
        }
        public static class MessageStatuses
        {
            public const int SEEN = 3;
            public const int RECEIVED = 2;
            public const int SENT = 1;
            public const int INACTIVE = 0;
        }
        public static class MessageTies
        {
            public const int MAXLENGTHINREVIEW = 18;
            public const int MAXLENGTHINCONTENT = 70;
        }
        public static class ConnectionsDescr
        {
            public const string CONNECTIONKEYWORD = "Connection";
            public const int NOTCONNECT = 0;
            public const int CONNECTED = 1;
            public const int CONNECTING = 2;
            //public const int CONFIRM = 3;
        }
    }
}
