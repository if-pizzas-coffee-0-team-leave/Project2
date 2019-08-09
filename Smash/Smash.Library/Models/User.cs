using System;
using System.Collections.Generic;
using System.Text;

namespace Smash.Library.Models
{
    public class User
    {
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public int UserId { get; set; }
        public decimal Skill { get; set; }
        public Favorite Fav { get; set; }
    }
}
