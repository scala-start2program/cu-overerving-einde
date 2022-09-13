using System;
using System.Collections.Generic;
using System.Linq;
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
using Scala.Overerving.Core;

namespace Scala.Overerving.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student("Alice Anderson", 18);
            student.Courses = new List<string>() { "Programming Basics", "Web Frontend Basics" };

            lblDetails.Content = student.ShowId();
        }

        private void ShowEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee("Bob Birch", 99, 1725.30m);
            lblDetails.Content = emp.ShowId();
        }

        private void ShowPerson_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MakePersons_Click(object sender, RoutedEventArgs e)
        {
            Employee emp1 = new Employee("Eve Everett", 25, 1230m);
            Employee emp2 = new Employee("Frank Fine", 38, 2568m);

            Student student1 = new Student("Gavin Grunt", 29);
            Student student2 = new Student("Helga Henderson", 16);
            Student student3 = new Student("Ian Iver", 19);

            List<Person> people = new List<Person>();
            people.Add(emp1);
            people.Add(emp2);
            people.Add(student1);
            people.Add(student2);
            people.Add(student3);

            lblDetails.Content = "";
            foreach (Person p in people)
            {
                lblDetails.Content += $"{p.ShowId()}\n";
            }

        }
    }
}
