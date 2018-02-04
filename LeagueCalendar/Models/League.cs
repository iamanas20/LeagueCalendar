using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueCalendar.Models
{
    public class League
    {
        public string Name { get; set; }

        private List<Team> Teams { get; set; }

        public List<Team> GetTeams() => Teams;

        public void SetTeams(List<Team> teamsList)
        {
            if (teamsList.Any())
            {
                Teams = teamsList;
            }
        }
         
        public int Year { get; set; }
    }
}