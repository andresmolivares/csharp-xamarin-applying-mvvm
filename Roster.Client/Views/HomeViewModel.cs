﻿using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _Title = "Roster App";

        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                NotifyChange(nameof(Title));
            }
        }

        private Command _UpdateApplicationCommand;
        public Command UpdateApplicationCommand
        {
            get 
            { 
                return _UpdateApplicationCommand ?? (_UpdateApplicationCommand = new Command(() => ExecuteUpdateApplication()));
            }
        }

        public void ExecuteUpdateApplication()
        { 
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