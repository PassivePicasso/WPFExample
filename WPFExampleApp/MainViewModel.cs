using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFExampleApp
{
    /// <summary>
    /// This very simple class just provides a collection of Sections that we want to present in a side bar that can be selected and presented in a main view
    /// </summary>
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
