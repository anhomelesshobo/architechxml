using System;
using System.Collections.Generic;
using System.Diagnostics;
using SchoolManagement.Models;
using SchoolManagement.Business;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static StudentDataService StudentData;

        static ObservableCollection<Student> etudiants;

        static ObservableCollection<Student> Etudiants
        {
            get => etudiants;
            set
            {
                etudiants = value;
                
            }
        }

        static void Main(string[] args)
        {
            StudentData = new StudentDataService();
            
        Etudiants = new ObservableCollection<Student>(StudentData.GetAll());

            foreach(Student g in Etudiants)
            {
                Console.WriteLine("Registration Number: " + g.RegistrationNumber);
                Console.WriteLine("First Name: " + g.FirstName);
                Console.WriteLine("Last Name: " + g.LastName);
                Console.WriteLine("");
                Console.WriteLine("");

        }
        Console.ReadLine();
    }

      
    }

