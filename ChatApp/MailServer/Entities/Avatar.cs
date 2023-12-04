using System;
using System.Collections.Generic;

namespace MailServer.Entities
{
    public partial class Avatar
    {
        public Avatar()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public byte[]? AvaImg { get; set; }
        public int? Status { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
