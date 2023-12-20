using System;
using System.Collections.Generic;

namespace MailServer.Entities
{
    public partial class Message
    {
        public int Id { get; set; }
        public int? IdFrom { get; set; }
        public int? IdTo { get; set; }
        public int? IdFile { get; set; }
        public string? ContentMsg { get; set; }
        public int? Status { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual File? IdFileNavigation { get; set; }
        public virtual User? IdFromNavigation { get; set; }
        public virtual User? IdToNavigation { get; set; }
    }
}
