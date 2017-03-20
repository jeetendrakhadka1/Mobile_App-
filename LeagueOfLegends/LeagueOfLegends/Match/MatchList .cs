using System.Collections.Generic;
using LeagueOfLegends.Core.Match;

namespace LeagueOfLegends.Core
{
    public class MatchList
    {
        public int endIndex { get; set; }
        public List<MatchReference> matches { get; set; }
        public int startIndex { get; set; }
        public int totalGames { get; set; }
    }
}