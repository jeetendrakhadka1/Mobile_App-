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

namespace Testing_riot_api.Core.Match
{
        public class MatchList
        {
            public int endIndex { get; set; }
            public List<MatchReference> matches { get; set; }
            public int startIndex { get; set; }
            public int totalGames { get; set; }
        }
    }