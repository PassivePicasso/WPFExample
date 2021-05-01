using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFExampleApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> sections;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<object> Sections
        {
            get => sections;
            set
            {
                sections = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sections)));
            }
        }

        public MainViewModel()
        {
            Sections = new ObservableCollection<object>();
            Sections.Add(new AlphaSectionViewModel() { Title = "Alpha Site" });
            Sections.Add(new BetaSectionViewModel() { Title = "Beta Site" });
        }
    }
}
