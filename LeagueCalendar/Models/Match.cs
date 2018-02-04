using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueCalendar.Models
{
    public class Match
    {
        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public DateTime Time { get; set; }
        
    }
}