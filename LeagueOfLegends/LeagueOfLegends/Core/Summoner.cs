using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LeagueOfLegends.Core
{
    public class Summoner
    {
        #region Summoner's Attributes

        public int id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel { get; set; }

        #endregion Summoner's Attributes
    }
    

    //    public class RootObject
    //    {
    //        public Summoner summoner { get; set; }
    //    }
}
