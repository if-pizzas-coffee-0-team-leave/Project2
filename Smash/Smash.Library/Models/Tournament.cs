using System;
using System.Collections.Generic;
using System.Text;

namespace Smash.Library.Models
{
    class Tournament
    {
        public int Id { get; set; }
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public int ParticipantCount { get; set; }
        public string Rules { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<User> Participants { get; set; }
    }
}
