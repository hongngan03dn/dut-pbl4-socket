using System;
using System.Collections.Generic;

namespace MailServer.Entities
{
    public partial class User
    {
        public User()
        {
            MessageIdFromNavigations = new HashSet<Message>();
            MessageIdToNavigations = new HashSet<Message>();
        }

        public int Id { get; set; }
        public int? IdRole { get; set; }
        public int? IdAvatar { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public DateTime? Bod { get; set; }
        public bool? Gender { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public int? Status { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Avatar? IdAvatarNavigation { get; set; }
        public virtual Role? IdRoleNavigation { get; set; }
        public virtual ICollection<Message> MessageIdFromNavigations { get; set; }
        public virtual ICollection<Message> MessageIdToNavigations { get; set; }
    }
}
