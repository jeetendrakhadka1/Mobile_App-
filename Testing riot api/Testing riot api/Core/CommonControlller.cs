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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Testing_riot_api.Core.Match;
using Android.Graphics;
using System.Net;
using Testing_riot_api.Core.Champions;

namespace Testing_riot_api.Core
{   
        public class CommonController
        {
            private const string BaseAddress = "https://na.api.pvp.net/api/lol/na/";
            private const string API_KEY = "?api_key=RGAPI-6ab48a8c-287d-4a63-be51-e8035b96f22d";
            private Summoner summoner;

            public CommonController()
            {
            }

            public CommonController(Summoner summoner)
            {
                this.summoner = summoner;
            }

            #region Api Calls

            /// <summary>
            ///  This Method will input the summoner's name and make an API call to return a summoner object
            /// </summary>
            public Uri GetSummonerCall(String name)
            {
                return new Uri("https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/"+name+"?api_key=2644294d-8403-42e3-8546-62007092462c");
            
            }

            public Summoner summonerFromJson(String json)
            {
                 return JsonConvert.DeserializeObject<Dictionary<String, Summoner>>(json).Values.FirstOrDefault();
            }

            public Bitmap GetImageBitmapFromUrl(string url)
                {
                Bitmap imageBitmap = null;
                if (!(url == "null"))
                using (var webClient = new WebClient())
                {
                    var imageBytes = webClient.DownloadData(url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    }
                }

            return imageBitmap;
        }
            
            public Uri GetMatchHistoryCall(String id)
            {
                return new Uri(BaseAddress + "v2.2/matchlist/by-summoner/" + id + API_KEY);
            }

            public MatchList MatchListFromJson(string json)
            {
                return JsonConvert.DeserializeObject<MatchList>(json);
            }
        /// <summary>
        ///  This Method will input the summary and make an API call to return the list of Matches
        /// </summary>
            public MatchStats GgetMatchStats(String json)
            {
                return JsonConvert.DeserializeObject<MatchStats>(json);
            }

            public Champion getChampionListFromJson(String json)
            {
            
            json = json.Remove(0, 44);
                return JsonConvert.DeserializeObject<Dictionary<string,Champion>>(json).Values.FirstOrDefault();
            }

            /// <summary>
            ///  This Method will input the matchId and make an API call to return the details about the match Id
            /// </summary>
            // NOT SURE CHANGE AS NEEDED
            public async Task<MatchReference> GetMatchDetails(int matchId)
            {
                // TODO: IMPLEMENTATION FOR GETTING THE MATCH DETAIL
                return new MatchReference();
            }
            
            public Uri getMatchStats(String id)
            {
                 return new Uri("https://na.api.pvp.net/api/lol/na/v1.3/game/by-summoner/" + id + "/recent?api_key=2644294d-8403-42e3-8546-62007092462c");
            }
            #endregion Api Calls
        }
    }
