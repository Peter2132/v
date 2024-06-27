using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class ResearchDocument
    {
        public int IdResearchDocument { get; set; }
        public int AppointmentId { get; set; }
        public string Namee { get; set; } = null!;
        public string Rtf { get; set; } = null!;
        public byte[]? Attachment { get; set; }

        
    }
}
