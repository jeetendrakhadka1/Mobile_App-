using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RitoGamesPlsApp.Src.Match
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            CommonController cc = new CommonController();
            Summoner s = cc.GetSummoner("TheYoungBasedGod").Result;
            NameLabel.Text ="Hi my name is carl";
        }
    }
}
