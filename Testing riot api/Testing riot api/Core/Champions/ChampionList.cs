using Newtonsoft.Json;
using System.Collections.Generic;

namespace Testing_riot_api.Core.Champions
{
    public class ChampionList
    {
        public int[] champId= new int []{24,37,18,110,114,27,223,7,412,43,202,68,77,64,83,38,15,21,119,157,10,35,58,120,105,96,57,127,222,6,3,80,91,41,81,150,17,1,82,268,85,92,31,266,78,163,420,74,12,5,236,106,113,76,86,89,238,53,33,161,51,48,203,9,113,245,267,50,44,134,72,201,45,101,42,111,103,126,122,23,40,60,67,63,104,16,30,8,26,55,102,19,115,240,121,2,4,20,107,432,39,427,62,22,429,84,254,32,117,25,56,131,136,143,112,69,75,29,36,61,28,421,99,14,164,11,13,54,34,98,59,90,154,79 };
        public string[] Key = new string[] { "Jax", "Sona","Tristana", "Varus", "Fiora","Singed","TahmKench","Leblanc","Thresh","Karma","Jhin","Rumble","Udyr","LeeSin","Yorick","Kassadin","Sivir","MissFortune","Draven","Yasuo","Kayle","Shaco","Renekton","Hecarim", "Fizz", "KogMaw", "Maokai", "Lissandra", "Jinx", "Urgot", "Galio", "Pantheon", "Talon", "Gangplank", "Ezreal", "Gnar", "Teemo", "Annie", "Mordekaiser", "Azir", "Kennen", "Riven","Chogath", "Aatrox", "Poppy", "Taliyah", "Illaoi", "Heimerdinger", "Alistar", "XinZhao", "Lucian","Volibear", "Sejuani","Nidalee", "Garen", "Leona", "Zed", "Blitzcrank","Rammus", "Velkoz", "Caitlyn", "Trundle", "Kindred", "FiddleSticks", "Quinn", "Ekko", "Nami", "Swain", "Taric", "Syndra", "Skarner", "Braum", "Veigar", "Xerath", "Corki", "Nautilus", "Ahri", "Jayce", "Darius", "Tryndamere", "Janna", "Elise", "Vayne", "Brand", "Graves", "Soraka", "Karthus", "Vladimir", "Zilean", "Katarina", "Shyvana", "Warwick", "Ziggs", "Kled", "Khazix", "Olaf", "TwistedFate", "Nunu", "Rengar", "Bard", "Irelia", "Ivern", "MonkeyKing", "Ashe", "Kalista", "Akali", "Vi", "Amumu", "Lulu", "Morgana", "Nocturne", "Diana", "AurelionSol", "Zyra", "Viktor", "Cassiopeia", "Nasus", "Twitch", "DrMundo", "Orianna", "Evelynn", "RekSai", "Lux", "Sion", "Camille", "MasterYi", "Ryze", "Malphite", "Anivia", "Shen", "JarvanIV", "Malzahar", "Zac", "Gragas", };

        public string getKeyFromChampId(int id)
        {
            for (int i = 0; i < champId.Length;i++)
            {
                if (champId[i] == id)
                {
                    return Key[i];
                }
            }
            return null;
        }

    }
}