using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class AppointmentDocument
    {
        public int IdAppointmentDocument { get; set; }
        public int AppointmentId { get; set; }
        public string Named { get; set; } = null!;
        public string Rtf { get; set; } = null!;

        
    }
}
