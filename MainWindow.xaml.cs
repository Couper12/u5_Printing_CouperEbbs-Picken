/* 
 * Couper Ebbs-Picken
 * 5/4/2018
 * Do more math
 */ 
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

namespace u5_Printing_CouperEbbsPicken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variable
        int copies = 0;
        public MainWindow()
        {

            InitializeComponent();

        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            // resets the contents of labels
            lblPricePerCopy.Content = "Price per copys is $";
            lblTotalPrice.Content = "Total cost is: $";

            // variable
            double price;

            // turns the string into an int
            int.TryParse(txtInput.Text, out copies);

            // what happens for less than 100 copies
            if (copies <= 99)
            {
                // changes price and updates the labels
                price = 0.30;
                lblPricePerCopy.Content += price.ToString();
                lblTotalPrice.Content += Math.Round(price * copies, 2).ToString();
            }

            // what happens for less than 500 but more than 100 copies
            if (copies <= 499
                && copies >= 100)
            {
                price = 0.28;
                lblPricePerCopy.Content += price.ToString();
                lblTotalPrice.Content += Math.Round(price * copies, 2).ToString();
            }

            // what happens for less than 750 but more than 500 copies
            if (copies <= 749
                && copies >= 500)
            {
                price = 0.27;
                lblPricePerCopy.Content += price.ToString();
                lblTotalPrice.Content += Math.Round(price * copies, 2).ToString();
            }

            // what happens for less than 1000 but more than 750 copies
            if (copies <= 1000
                && copies >= 750)
            {
                price = 0.26;
                lblPricePerCopy.Content += price.ToString();
                lblTotalPrice.Content += Math.Round(price * copies, 2).ToString();
            }

            // what happens for more than 1000 copies
            if (copies > 1000)
            {
                price = 0.25;
                lblPricePerCopy.Content += price.ToString();
                lblTotalPrice.Content += Math.Round(price * copies, 2).ToString();
            }
        }
    }
}
