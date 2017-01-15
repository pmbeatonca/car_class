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

namespace Car_Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car car;
        public MainWindow()
        {
            InitializeComponent();
     
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string make = txtMake.Text;
            int year = Convert.ToInt32(txtYear.Text);
            car = new Car(year, make);
            lblMake.Content = car.Make;
            lblSpeed.Content = car.Speed;
            lblYear.Content = car.Year;
        }

        private void btnAcc_Click(object sender, RoutedEventArgs e)
        {
            car.Accelerate();
            lblSpeed.Content = car.Speed;          

        }

        private void Brake_Click(object sender, RoutedEventArgs e)
        {
            car.Break();
            lblSpeed.Content = car.Speed;
        }
    }
}
