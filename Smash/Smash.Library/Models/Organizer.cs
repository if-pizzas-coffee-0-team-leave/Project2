using System;
using System.Collections.Generic;
using System.Text;

namespace Smash.Library.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public DateTime Updated { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
