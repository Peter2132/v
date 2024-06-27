using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class Appointment
    {
        

        public int IdAppointment { get; set; }
        public long OmsId { get; set; }
        public int DoctorId { get; set; }
        public int StatusId { get; set; }
        

        
    }
}
