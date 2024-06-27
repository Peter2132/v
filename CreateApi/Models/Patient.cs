using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class Patient
    {
        

        public long IdOms { get; set; }
        public string Surname { get; set; } = null!;
        public string Namee { get; set; } = null!;
        public string? Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string AddressP { get; set; } = null!;
        public string? LivingAddress { get; set; }
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string? Nickname { get; set; }

       
    }
}
