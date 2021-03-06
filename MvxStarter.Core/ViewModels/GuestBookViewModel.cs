using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvxStarter.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvxStarter.Core.ViewModels
{
    public class GuestBookViewModel : MvxViewModel
    {
        private ObservableCollection<PersonModel> _people = new ObservableCollection<PersonModel>();
        private string _firstName;
        private string _lastName;

        public GuestBookViewModel()
        {
            AddGuestCommand = new MvxCommand(AddGuest);
        }

        public ObservableCollection<PersonModel> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(() => FullName);
                RaisePropertyChanged(() => CanAddGuest);
            }
        }
        
        
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(() => FullName);
                RaisePropertyChanged(() => CanAddGuest);
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public void AddGuest()
        {
            PersonModel p = new PersonModel
            {
                FirstName = FirstName,
                LastName = LastName
            };

            FirstName = string.Empty;
            LastName = string.Empty;
            People.Add(p);
        }

        public IMvxCommand AddGuestCommand { get; set; }

        public bool CanAddGuest => (FirstName?.Length > 0) && (LastName?.Length > 0);

    }
}
