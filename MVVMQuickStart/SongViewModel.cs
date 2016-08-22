using System.Windows.Input;
using MicroMvvm;

namespace MVVMQuickStart
{
    public class SongViewModel : ObservableObject
    {
        private Song _song;
        private int counter;

        public SongViewModel()
        {
            _song = new Song() { ArtistName = "Unknown", SongTitle = "Unknown" };
            counter = 0;
        }

        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }

        public string ArtistName
        {
            get { return Song.ArtistName; }
            set
            {
                Song.ArtistName = value;
                RaiseProperyCHanged("ArtistName");
            }
        }

        public string SongeTitle
        {
            get { return Song.SongTitle; }
            set
            {
                Song.SongTitle = value;
                RaiseProperyCHanged("SongeTitle");
            }
        }
        
        void UpdateSongeDetailsExecute()
        {
            ArtistName = "Abdel Fattah El Greeny " + (++counter);
            SongeTitle = "Jabra Fan";
        }

        bool CanUpdateSongeDetailsExecute()
        {
            return true;
        }

        public ICommand UpdateSongeDetails => new RelayCommand(UpdateSongeDetailsExecute, CanUpdateSongeDetailsExecute);
    }
}
