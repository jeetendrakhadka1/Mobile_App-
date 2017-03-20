using System.Collections.Generic;

namespace LeagueOfLegends.Core.Match
{
        public class MatchList
        {
            public int endIndex { get; set; }
            public List<MatchReference> matches { get; set; }
            public int startIndex { get; set; }
            public int totalGames { get; set; }
        }
    }