using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODEL.Dto
{
    public class RegUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}