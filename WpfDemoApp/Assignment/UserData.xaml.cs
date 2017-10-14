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
using System.Collections.ObjectModel;

namespace WpfDemoApp.Assignment
{
    /// <summary>
    /// Interaction logic for UserData.xaml
    /// </summary>
    /// 
    
    public partial class UserData : Window
    {
        ObservableCollection<UserInterface> userlist;
        public UserData()
        {
            InitializeComponent();
            Loaded += UserData_Loaded;
        }

        private void UserData_Loaded(object sender, RoutedEventArgs e)
        {
            userlist = new ObservableCollection<UserInterface>();
            userlist.Add(new UserInterface
            {
                Username = "Tintin",
                Age = 35,
                Favcolor = "Orange",
                Image=""
                
            });
            userlist.Add(new UserInterface
            {
                Username = "Rocky",
                Age = 37,
                Favcolor = "Yellow",
                Image = ""
            });
            userlist.Add(new UserInterface
            {
                Username = "Bharat",
                Age = 62,
                Favcolor = "Green",
                Image = ""
            });
            this.DataContext = userlist;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            userlist.Add(new UserInterface
            {
                Username = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Favcolor = txtFavColor.Text,
                Image = txtName.Text + ".jpg"
            });
        }
    }
}
