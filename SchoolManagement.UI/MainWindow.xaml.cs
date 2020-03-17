using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SchoolManagement;
using SchoolManagement.Models;
using SchoolManagement.Business;


namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int Itemselected=0;
        StudentDataService StudentData;
    
        private ObservableCollection<Student> etudiants;
        private int ledernierid;

        public ObservableCollection<Student> Etudiants
        {
            get => etudiants;
            set
            {
                etudiants = value;
                OnPropertyChanged();
            }
        }

       

        public MainWindow()
        {
            InitializeComponent();

            InitValues();
        }

        private void InitValues()
        {
           
            StudentData = new StudentDataService();
            Etudiants = new ObservableCollection<Student>(StudentData.GetAll());
            ledernierid=Etudiants[Etudiants.Count-1].StudentId;
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void supprimerStudent(object sender, RoutedEventArgs e)
        {
            Etudiants.Remove((Student)mydatagrid.SelectedItem);
        }

        private void NouveauStudents(object sender, RoutedEventArgs e)
        {
            ledernierid++;
            Etudiants.Add(new Student { StudentId = ledernierid, RegistrationNumber = "", FirstName = "", LastName = "" });
            
        }

        private void ModifierStudent(object sender, RoutedEventArgs e)
        {
            Itemselected = mydatagrid.SelectedIndex;
            ImageModif newWindow = new ImageModif(Etudiants[mydatagrid.SelectedIndex]);
            newWindow.ShowDialog();
        }
    }
}
