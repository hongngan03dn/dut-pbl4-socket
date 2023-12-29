using System;
using System.Collections.Generic;

namespace MailServer.Entities
{
    public partial class File
    {
        public File()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public int? Status { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
