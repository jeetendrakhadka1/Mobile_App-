<<<<<<< HEAD
﻿using RitoGamesPlsApp.Src.Views;
=======
﻿using RitoGamesPlsApp.Src;
using RitoGamesPlsApp.Src.Match;
>>>>>>> bb53c17ba51bf3557efcde995c5be7a9b7e9c7ec
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RitoGamesPlsApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "RitoGamesPlsApp",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
=======
            /*
            var content = new ContentPage
            {
                Title = "RitoGamesPlsApp",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
>>>>>>> bb53c17ba51bf3557efcde995c5be7a9b7e9c7ec

            MainPage =  new NavigationPage(new HomePage());
        }
        */
            MainPage = new UserPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
