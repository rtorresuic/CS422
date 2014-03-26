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

namespace DUI_4
{
    /// <summary>
    /// Interaction logic for dataSelection.xaml
    /// </summary>
    public partial class dataSelection : Window
    {
        public dataSelection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            users u = new users();
            u.Show(); 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            deaths d = new deaths();
            d.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            money m = new money();
            m.Show();
        }
    }
}
