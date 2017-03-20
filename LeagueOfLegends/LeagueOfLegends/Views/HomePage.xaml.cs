using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;
using Android.Text;
using LeagueOfLegends.Core;
using LeagueOfLegends.Views;
using Xamarin.Android;

namespace LeagueOfLegends.Views
{
    public partial class HomePage : ContentPage
    {

		public static IEnumerable<Summoner> ItemsSource {
			get {
				throw new System.NotImplementedException ();
			}

			set {
				throw new System.NotImplementedException ();
			}
		}

		static void Handle_ItemSelected (HomePage instance, object sender,Xamarin.Android.SelectedItemChangedEventArgs e)
		{
			var summoner = e.SelectedItem as Summoner;
			NewMethod (summoner);
		}

		static void NewMethod (Summoner summoner)
		{
			throw new NotImplementedException ();
		}

		IEnumerable<Summoner> GetSummoners(String searchText = null)
        {
            
            var summoners = new List<Summoner>
            {
                new Summoner { name = "Annie" },
                new Summoner { name = "Nasus" },
                new Summoner { name = "Hecarim" },
                new Summoner { name = "Soraka" },
                new Summoner { name = "Impish"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                 return summoners;

            return summoners.Where(c => c.name.StartsWith(searchText));
        }

			public static IEnumerable<Summoner> ItemSource { get; internal set; }


		void InitializeComponent ()
		{
			throw new NotImplementedException ();
		}

		class listView
		{
			List<Summoner> summoners = new List<Summoner>
			{
				new Summoner { name = "Annie" },
				new Summoner { name = "Nasus" },
				new Summoner { name = "Hecarim" },
				new Summoner { name = "Soraka" },
				new Summoner { name = "Impish"}
			};

		}
	}
}
