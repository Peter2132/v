using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class AnalysisDocument
    {
        public int IdAnalysisDocument { get; set; }
        public int AppointmentId { get; set; }
        public string Namee { get; set; } = null!;
        public string Rtf { get; set; } = null!;

        
    }
}
