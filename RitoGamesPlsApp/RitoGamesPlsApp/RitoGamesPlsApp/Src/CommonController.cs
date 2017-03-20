using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RitoGamesPlsApp.Src.Match;

namespace RitoGamesPlsApp.Src
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
        public async Task<Summoner> GetSummoner(String name = null)
        {
            Summoner result = null;
            HttpClient client = new HttpClient();
            var response =  await client.GetStringAsync(new Uri(BaseAddress + "v1.4/summoner/by-name/" + name + API_KEY));
            if (response != null)
            {
                result = JsonConvert.DeserializeObject<Summoner>(response);
            }
            return result;
        }

        /// <summary>
        ///  This Method will input the summary and make an API call to return the list of Matches
        /// </summary>
        public async Task<MatchList> GetMatchHistory(Summoner summoner)
        {
            MatchList result = null;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(new Uri(BaseAddress + "v2.2/matchlist/by-summoner/" + summoner.id + API_KEY));
            if (response != null)
            {
                result = JsonConvert.DeserializeObject<MatchList>(response);
            }
            return result;
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

        #endregion Api Calls
    }
}