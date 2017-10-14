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
using System.Windows.Shapes;

namespace WpfDemoApp.Binding
{
    /// <summary>
    /// Interaction logic for PersonBindingWindow.xaml
    /// </summary>
    public partial class PersonBindingWindow : Window
    {
        Person _person;
        public PersonBindingWindow()
        {
            InitializeComponent();
            Loaded += PersonBindingWindow_Loaded;
        }

        private void PersonBindingWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _person = new Person { Age = 19, Name = "Donald" };
            this.DataContext = _person;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Name :- {_person.Name},\n Age :-{_person.Age}");
        }

        private void btnAssing_Click(object sender, RoutedEventArgs e)
        {
            _person.Name = "Vishal";
            _person.Age = 26;
        }
    }
}
