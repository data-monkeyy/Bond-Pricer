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

namespace WpfUI
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
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double couponRate, riskFreeRate, duration, parValue, presentValue;

            // Parse the input values as doubles
            if (double.TryParse(couponRateTextBox.Text, out couponRate) &&
                double.TryParse(riskFreeRateTextBox.Text, out riskFreeRate) &&
                double.TryParse(durationTextBox.Text, out duration) &&
                double.TryParse(parValueTextBox.Text, out parValue))
            {
                   
                presentValue = ((couponRate * parValue) * (1 - Math.Pow(1 + riskFreeRate, (-1) * duration))/riskFreeRate) + parValue/(Math.Pow(1+riskFreeRate, duration)); 
                // Display the present value in the appropriate TextBox
                presentValueTextBox.Text = presentValue.ToString();
            }
            else
            {
                // If any of the input values are invalid, display an error message
                presentValueTextBox.Text = "Invalid input";
            }
        }
    }


}
