using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueOfLegends.Core;
using Xamarin.Android;

namespace LeagueOfLegends.Views
{
    public partial class SummonerDetailPage : ContentPage
    {
		public Summoner BindingContext { get; private set; }

      
        public SummonerDetailPage( Summoner summoner)
        {
            if (summoner == null)
                throw new ArgumentNullException();

			BindingContext = summoner;

			InitializeComponent();
        }

		void InitializeComponent ()
		{
			throw new NotImplementedException ();
		}
}

	public class ContentPage
	{
		
	}
}
