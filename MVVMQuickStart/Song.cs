using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMQuickStart
{
    public class Song
    {
        private string _artistName;
        private string _songTitle;

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }

        public string SongTitle
        {
            get { return _songTitle; }
            set { _songTitle = value; }
        }
    }
}
