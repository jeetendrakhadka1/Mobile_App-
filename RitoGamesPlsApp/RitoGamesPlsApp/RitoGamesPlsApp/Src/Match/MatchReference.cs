using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitoGamesPlsApp.Src.Match
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