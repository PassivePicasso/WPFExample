using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class BetaSectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string title;
        private string subTitle;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                //If we want to inform the UI that this property has changed we must invoke the PropertyChanged Event
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public string SubTitle
        {
            get => subTitle;
            set
            {
                subTitle = value;
                //If we want to inform the UI that this property has changed we must invoke the PropertyChanged Event
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SubTitle)));
            }
        }
    }
}
