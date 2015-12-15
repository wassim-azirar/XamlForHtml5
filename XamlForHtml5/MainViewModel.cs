using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlForHtml5
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _changeCommand;

        public RelayCommand ChangeCommand
        {
            get { return _changeCommand ?? new RelayCommand(ChangeCommandExecute); }
        }

        private void ChangeCommandExecute()
        {
            Message = "The command has been executed";
        }

        public MainViewModel()
        {
            Message = "Hello world ";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}