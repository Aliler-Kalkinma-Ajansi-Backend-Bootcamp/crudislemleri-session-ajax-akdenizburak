using System;
using System.Collections.Generic;

#nullable disable

namespace bookshelf.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RentBook { get; set; }
    }
}
