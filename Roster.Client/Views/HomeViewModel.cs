using Roster.Client.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() => ExecuteUpdateApplication());
        }

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

        public Command UpdateApplicationCommand { get; }

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
        public void NotifyChange(string propertyName)
        {
            if (PropertyChanged is not null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}