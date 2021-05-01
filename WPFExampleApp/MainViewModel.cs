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


        /// <summary>
        /// ObservableCollection implements INotifyCollectionChanging and INotifyCollectionChanged and when Add or Remove are invoked it will invoke its change events and the UI will update
        /// </summary>
        public ObservableCollection<object> Sections
        {
            get => sections;
            set
            {
                sections = value;
                //If we want to inform the UI that this property has changed we must invoke the PropertyChanged Event
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
