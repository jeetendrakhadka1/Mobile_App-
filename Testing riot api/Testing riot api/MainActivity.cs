using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.IO;
using Android.Graphics;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using Newtonsoft.Json;
using Testing_riot_api.Core;
using Microsoft.CSharp.RuntimeBinder;
using System.Linq;
using Testing_riot_api.Core.Match;
using Testing_riot_api.Core.Champions;

namespace Testing_riot_api
{
    [Activity(Label = "Testing_riot_api", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Uri mUriSummoner;
        private Uri mUriMatchHistory;
        private Uri mUriChamps = new Uri("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?api_key=2644294d-8403-42e3-8546-62007092462c");
        private WebClient mClient;
        private LinearLayout ll1;
        private LinearLayout ll2;
        private Summoner mSummoner;
        private TextView msumName;
        private TextView mlvl;
        private ImageView mImage;
        private ListView mListMatches;
        private MatchHistoryViewAdapter mAdapter;
        private MatchList mMatches;
        private CommonController cc = new CommonController();
        private ChampionList mChampList;
        private Uri mRecentMatches;
        private MatchStats mStats;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            mUriSummoner = cc.GetSummonerCall("TheYoungBasedGod");
            mClient = new WebClient();
            mMatches = new MatchList();
            mChampList = new ChampionList();
            mStats = new MatchStats();
            
            ll1 = FindViewById<LinearLayout>(Resource.Id.LinLay1);
            ll2 = ll1.FindViewById<LinearLayout>(Resource.Id.LinLay2);
            msumName = ll2.FindViewById<TextView>(Resource.Id.SumName);
            mlvl = ll2.FindViewById<TextView>(Resource.Id.sumLvl);
            mImage = ll1.FindViewById<ImageView>(Resource.Id.sumImage);
            mListMatches = FindViewById<ListView>(Resource.Id.listView1);
            mClient.DownloadDataAsync(mUriSummoner);
            mClient.DownloadDataCompleted += mClient_DownloadDataCompleted;
          
            

            

            
          
            

        }

        void mClient_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            RunOnUiThread(() =>
            {
                string json = Encoding.UTF8.GetString(e.Result);
                mSummoner = cc.summonerFromJson(json);
                msumName.Text =mSummoner.name;
                mlvl.Text = mSummoner.summonerLevel.ToString();
                var bitmap = cc.GetImageBitmapFromUrl("http://ddragon.leagueoflegends.com/cdn/7.3.3/img/profileicon/"+mSummoner.profileIconId+".png ");
                mImage.SetImageBitmap(bitmap);
                mClient = new WebClient();
                mUriMatchHistory = cc.GetMatchHistoryCall(mSummoner.id.ToString());
                 mClient.DownloadDataAsync(mUriMatchHistory);
                    mClient.DownloadDataCompleted += mClient_DownloadDataCompletedMatchHistory;


            });
        }
        void mClient_DownloadDataCompletedMatchHistory(object sender, DownloadDataCompletedEventArgs e)
        {
            RunOnUiThread(() =>
            {
                  string json = Encoding.UTF8.GetString(e.Result);
                  mMatches = cc.MatchListFromJson(json);
                  mAdapter = new MatchHistoryViewAdapter(this, mMatches.matches, Resource.Layout.MHRow);
                  mListMatches.Adapter = mAdapter;




            });
        }

    }
}

