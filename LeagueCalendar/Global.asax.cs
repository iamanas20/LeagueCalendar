using LeagueCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LeagueCalendar
{
    public class Global : System.Web.HttpApplication
    {

        public static League twentyEighteenLeague;

        private List<Match> matchesList;
        private List<Team> Teams;

        /// <summary>
        /// This is executed when the app starts, equivalent to the App object in UWP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            matchesList = new List<Match>();
            Teams = new List<Team> { new Team { Name = "Santrana FC" }, new Team { Name = "Mongrano City" }, new Team { Name = "Bariali" }, new Team { Name = "FC Chaylak" }, };

            twentyEighteenLeague = new League { Name = "Antartican Second League", Year = 2018 };
            twentyEighteenLeague.SetTeams(Teams);

            List<DateTime> dateTime = new List<DateTime> { new DateTime(2018, 1, 2), new DateTime(2018, 1, 31), new DateTime(2018, 2, 4), new DateTime(2018, 2, 15), new DateTime(2018, 2, 19), new DateTime(2018, 2, 25) };
            int i = 0;
            foreach (var homeTeam in Teams)
            {
                foreach (var awayTeam in Teams)
                {
                    if (!homeTeam.Equals(awayTeam) && Teams.IndexOf(awayTeam) > Teams.IndexOf(homeTeam))
                    {
                        matchesList.Add(new Match { HomeTeam = homeTeam, AwayTeam = awayTeam, Time = dateTime[i]});
                        i++;
                    }
                }
            }

            //twentyEighteenLeague.SetMatches(new List<Match> { new Match { HomeTeam = twentyEighteenLeague.GetTeams()[0] } });


        }
    }
}