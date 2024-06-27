using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class Doctor
    {
        

        public int IdDoctor { get; set; }
        public string Surname { get; set; } = null!;
        public string Namee { get; set; } = null!;
        public string? Patronymic { get; set; }
        public int SpecialityId { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string WorkAddress { get; set; } = null!;

        
    }
}
