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

        private List<Match> Matches { get; set; }

        public List<Team> GetTeams() => Teams;
        
        public void SetTeams(List<Team> teamsList)
        {
            if (teamsList.Any())
            {
                Teams = teamsList;
            }
        }

        public List<Match> GetMatches() => Matches;

        public void SetMatches(List<Match> matchList)
        {
            if (matchList.Any())
            {
                Matches = matchList;
            }
        }
         
        public int Year { get; set; }
    }
}