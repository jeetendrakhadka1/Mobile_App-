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
        public class MatchReference
        {
            public long champion { get; set; }
            public string lane { get; set; }
            public long matchId { get; set; }
            public string platformId { get; set; }
            public string queue { get; set; }
            public string region { get; set; }
            public string role { get; set; }
            public string season { get; set; }
            public long timestamp { get; set; }
        }
    }