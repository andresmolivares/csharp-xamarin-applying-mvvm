using Roster.Client.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string title = "Roster App";

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                NotifyChange(nameof(Title));
            }
        }

        private Command _UpdateApplicationCommand;
        public Command UpdateApplicationCommand
        {
            get 
            { 
                return _UpdateApplicationCommand 
                    ?? (_UpdateApplicationCommand = new Command(() => ExecuteUpdateApplication()));
            }
        }

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>
        { 
            new Person { Name = "Delores Feil", Company = "Legros Group" },
            new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" },
            new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" }
        };

        public void ExecuteUpdateApplication()
        {
            Title = "Roster App (v2.0)";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyChange(string propertyName)
        {
            if (PropertyChanged is not null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}