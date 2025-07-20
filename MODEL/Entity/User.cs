using MODEL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class User : CoreEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public UserStatus Status { get; set; }
        public string ProfilePhoto { get; set; }
        public DateTime? LastSeen { get; set; }
    }

    public enum UserStatus
    {
        [Description("Çevrimdışı")]
        Offline,

        [Description("Çevrimiçi")]
        Online,

        [Description("Meşgul")]
        Busy,

        [Description("Dışarıda")]
        Away
    }
}