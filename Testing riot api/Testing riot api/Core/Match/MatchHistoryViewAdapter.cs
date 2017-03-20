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
using Testing_riot_api.Core.Champions;


namespace Testing_riot_api.Core.Match
{
    class MatchHistoryViewAdapter : BaseAdapter<MatchReference>
    {
        public List<MatchReference> mMatches;
        private Context mContext;
        public int mLayout;
        
        public CommonController cc;
        public ChampionList mCL;

        public MatchHistoryViewAdapter(Context mContext, List<MatchReference> mMatches, int mLayout)
        {
            this.mMatches = mMatches;
            this.mContext = mContext;
            this.mLayout = mLayout;
        }

        public override MatchReference this[int position]
        {
            get
            {
                return mMatches[position];
            }
        }

        public override int Count
        {
            get
            {
                return mMatches.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.MHRow, parent, false);
            }
            
            row.FindViewById<TextView>(Resource.Id.thisIsARoll).Text = mMatches[position].lane;
            row.FindViewById<TextView>(Resource.Id.Que).Text = mMatches[position].queue;

            ImageView pic = row.FindViewById<ImageView>(Resource.Id.chaampPic);
            long key = mMatches.FirstOrDefault(x => x.champion == mMatches[position].champion).champion;
            cc = new CommonController();
            mCL = new ChampionList();
            string newName =  mCL.getKeyFromChampId((int)key);
            pic.SetImageBitmap(cc.GetImageBitmapFromUrl("http://ddragon.leagueoflegends.com/cdn/7.3.3/img/champion/"+newName+".png "));
            return row;
            
            
        }

     
    }
}