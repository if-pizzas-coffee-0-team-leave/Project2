using System;
using System.Collections.Generic;
using System.Text;

namespace Smash.Library.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FavMapId { get; set; }
        public int FavTournamentId { get; set; }
        public DateTime Modified { get; set; }
    }
}
