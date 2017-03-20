using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RitoGamesPlsApp.Src.Views
{
    public partial class HomePage : ContentPage
    {
        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
           listView.ItemsSource = GetSummoners(e.NewTextValue);
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var summoner = e.SelectedItem as Summoner;

            Navigation.PushAsync(new SummonerDetailPage(summoner));
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
        public HomePage()
        {
            InitializeComponent();
            listView.ItemsSource = GetSummoners();
            
        }
    }
}
