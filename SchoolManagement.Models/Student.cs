using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SchoolManagement.Models
{
    public class Student : INotifyPropertyChanged
    {
        private string registrationNumber;
        private string firstName;
        private string lastName;

        public int StudentId { get; set; }

        public string RegistrationNumber
        {
            get => registrationNumber;
            set
            {
                registrationNumber = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
