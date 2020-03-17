using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SchoolManagement.Models;
using SchoolManagement.UI;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Logique d'interaction pour ImageModif.xaml
    /// </summary>
    public partial class ImageModif : Window,INotifyPropertyChanged
    {
        Student student;
    
        public Student Student
        {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

        public ImageModif(Student _students)
        {
            InitializeComponent();
            Student = _students;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void modifier(object sender, RoutedEventArgs e)
        {
            Student.FirstName = FirstnameModif.Text;
            Student.LastName = LastnameModif.Text;
            Student.RegistrationNumber = RegistrationnumberModif.Text;

            this.Close();
        }
    }
}
