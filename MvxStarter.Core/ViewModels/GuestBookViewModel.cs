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

        public ObservableCollection<PersonModel> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        
        
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }





    }
}
