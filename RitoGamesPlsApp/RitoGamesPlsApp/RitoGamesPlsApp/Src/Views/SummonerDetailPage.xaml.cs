using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RitoGamesPlsApp.Src.Views
{
    public partial class SummonerDetailPage : ContentPage
    {
      
        public SummonerDetailPage( Summoner summoner)
        {
            if (summoner == null)
                throw new ArgumentNullException();

            BindingContext = summoner;

            InitializeComponent();
        }
    }
}
