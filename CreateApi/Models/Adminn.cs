using System;
using System.Collections.Generic;

namespace CreateApi.Models
{
    public partial class Adminn
    {
        public int IdAdmin { get; set; }
        public string Surname { get; set; } = null!;
        public string Namee { get; set; } = null!;
        public string? Patronymic { get; set; }
        public string PasswordHash { get; set; } = null!;
    }
}
