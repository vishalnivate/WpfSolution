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
    /// Interaction logic for TurningEventWindow.xaml
    /// </summary>
    public partial class TurningEventWindow : Window
    {
        public TurningEventWindow()
        {
            InitializeComponent();
            Button.PreviewMouseDown += Button_PreviewMouseDown;
            InnerSt.PreviewMouseDown += InnerSt_PreviewMouseDown;
            RootSt.PreviewMouseDown += RootSt_PreviewMouseDown;
        }

        private void RootSt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comming From Root Panel");
        }

        private void InnerSt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comming From Inner Panel");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comming From Button");
        }
    }
}
