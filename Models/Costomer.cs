using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class Costomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Geander { get; set; }
        public string Imges { get; set; }
    }
}
