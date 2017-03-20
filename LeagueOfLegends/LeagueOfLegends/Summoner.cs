using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LeagueOfLegends.Core.Match;

namespace LeagueOfLegends.Views
{
    public class Summoner
    {
        #region Summoner's Attributes

        public int id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel { get; set; }
        public string status { get; set; }

        #endregion Summoner's Attributes
    }
}