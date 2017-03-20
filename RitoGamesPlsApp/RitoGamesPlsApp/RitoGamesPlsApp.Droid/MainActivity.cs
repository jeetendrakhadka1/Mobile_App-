using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using RitoGamesPlsApp.Src;

namespace RitoGamesPlsApp.Droid
{
    [Activity(Label = "RitoGamesPlsApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
/*
           
            SetContentView(Resource.Layout.UserPage);
            ImageView mIcon;
            TextView mSumName;
            TextView mSumLvl;
            //    mIcon = FindViewById<ImageView>(Resource.Id.SumIcon);
            //mSumName = FindViewById<TextView>(Resource.Id.SumName);
            // mSumLvl = FindViewById<TextView>(Resource.Id.SumLvl);

            CommonController CC = new CommonController();
            Summoner s = new Summoner();
            // s = CC.GetSummoner("TheYoungBasedGod").Result;
            // mSumName.Text = s.name;
            // mSumLvl.Text = s.summonerLevel.ToString();
            */
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

    }
}