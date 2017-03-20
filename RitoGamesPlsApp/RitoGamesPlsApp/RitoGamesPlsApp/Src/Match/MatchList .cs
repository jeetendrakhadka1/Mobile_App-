using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RitoGamesPlsApp.Src.Match;

namespace RitoGamesPlsApp.Src
{
    public class MatchList
    {
        public int endIndex { get; set; }
        public List<MatchReference> matches { get; set; }
        public int startIndex { get; set; }
        public int totalGames { get; set; }
    }
}