using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace _04_List_Controls_Collection_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // INotifyCollectionChanged
        ObservableCollection<Person> people = null;
        public MainWindow()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>()
            {
                new Person(){ Name = "Bogdan", SurName="Bogdanenko", Birth = new DateTime(2000,12,3)},
                new Person(){ Name = "Victoria", SurName="Ivanchuk", Birth = new DateTime(1998,6,18)},
                new Person(){ Name = "Sasha", SurName="Marchuk", Birth = new DateTime(2010,8,13)}
            };

            comboBox.Items.Clear();
            //foreach (var item in people)
            //{
            //    comboBox.Items.Add(item);
            //}
        
            comboBox.ItemsSource = people;
            comboBox.DisplayMemberPath = nameof(Person.FullName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newpeople = new Person()
            {
                Name = "New Name",
                SurName = "New surname",
                Birth = new DateTime(2010, 8, 13)
            };
            people.Add(newpeople);
            //comboBox.Items.Add(newpeople);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex != -1)
                people.RemoveAt(comboBox.SelectedIndex);    
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            people.Clear();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox.SelectedItem != null)
                MessageBox.Show(comboBox.SelectedItem.ToString());
        }
    }
}
