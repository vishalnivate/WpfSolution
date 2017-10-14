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

namespace WpfDemoApp.Events
{
    /// <summary>
    /// Interaction logic for BubblingWindow.xaml
    /// </summary>
    public partial class BubblingWindow : Window
    {
        public BubblingWindow()
        {
            InitializeComponent();

            CheckBox.KeyDown += CheckBox_KeyDown;
            Button1.KeyDown += Button1_KeyDown;
            InnerSt.KeyDown += InnerSt_KeyDown;
            RootSt.KeyDown += RootSt_KeyDown;
        }

        private void RootSt_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming From Root Stake Panel");
        }

        private void InnerSt_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming From Inner Stack Panel");
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming From Button");
        }

        private void CheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Comming From Check Box");
        }
    }
}
