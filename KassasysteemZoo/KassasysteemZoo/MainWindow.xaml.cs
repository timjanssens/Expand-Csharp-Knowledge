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

namespace KassasysteemZoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declaration constants
        const int BabyAge = 4;
        const int ChildAge = 12;
        const int PriceChild = 12;
        const int PriceAdult = 18;

        //declaration variables
        byte age = 0;
        int babyCount = 0;
        int childCount = 0;
        int adultCount = 0;
        int totalPersonsCount = 0;
        int fantaCount = 0;
        int candyCount = 0;
        int friesCount = 0;
        double priceWholeGroup = 0;
        double discountTotal = 0;
        double discountChild = 0;
        double discountAdult = 0;
        double grandTotal = 0;
        decimal maps = 0;
        double grandTotalHelp = 0;


        
        public MainWindow()
        {
            InitializeComponent();
            txtLeeftijd.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //check if the input is a byte
            if (byte.TryParse(txtLeeftijd.Text, out age))
            {
                //divide persons in age groups
                if (age < BabyAge)
                    babyCount++;
                else if (age < ChildAge)
                    childCount++;
                else
                    adultCount++;
                
                //check wich gift is chosen
                if (rdbFanta.IsChecked == true)
                    fantaCount++;
                else if (rdbCandy.IsChecked == true)
                    candyCount++;
                else
                    friesCount++;

                //add total counter
                totalPersonsCount++;

                //update amount of persons per group
                txtYoungerThan4.Text = babyCount.ToString();
                txtYoungerThan12.Text = childCount.ToString();
                txtOlderThan12.Text = adultCount.ToString();
                txtTotalPersons.Text = totalPersonsCount.ToString();

                //update gifts per group
                txtFanta.Text = fantaCount.ToString();
                txtCandy.Text = candyCount.ToString();
                txtFries.Text = friesCount.ToString();


                //calculate the price for the whole group
                priceWholeGroup = (childCount * PriceChild) + (adultCount * PriceAdult);

                //calculate discount
                if (childCount >= 5)
                    discountChild = (childCount * PriceChild) * 0.1;
                if (adultCount >= 5)
                    discountAdult = (adultCount * PriceAdult) * 0.2;

                discountTotal = discountAdult + discountChild;

                //subtract discount from price for the whole group
                priceWholeGroup -= discountTotal;

                //update the pricePerGroupField and discount
                txtTotalBill.Text = priceWholeGroup.ToString();
                txtDiscount.Text = discountTotal.ToString();

                //put focus after input back on input field
                txtLeeftijd.Focus();

                //empty the input field
                txtLeeftijd.Text = string.Empty;

                //get grandtotal;
                grandTotal = grandTotalHelp + priceWholeGroup;


                txtGrandTotal.Text = grandTotal.ToString();

                //calculate maps

                maps = (decimal)totalPersonsCount / 4;
                txtMaps.Text = Math.Ceiling(maps).ToString();
             

             

            }
            else
            {
                MessageBox.Show("It must be a number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLeeftijd.Focus();
                txtLeeftijd.Text = string.Empty;

            }
        }
        /// <summary>
        /// close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNewGroup_Click(object sender, RoutedEventArgs e)
        {
            //focus back on input field
            txtLeeftijd.Focus();

            //empty all fields amount of persons per group
            txtLeeftijd.Text = string.Empty;
            txtYoungerThan4.Text = string.Empty;
            txtYoungerThan12.Text = string.Empty;
            txtOlderThan12.Text = string.Empty;
            txtTotalPersons.Text = string.Empty;
            txtTotalBill.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtFanta.Text = string.Empty;
            txtCandy.Text = string.Empty;
            txtFries.Text = string.Empty;
            
       


            //reset amount of persons per group
            babyCount = 0;
            childCount = 0;
            adultCount = 0;
            totalPersonsCount = 0;
            priceWholeGroup = 0;
            discountTotal = 0;
            fantaCount = 0;
            candyCount = 0;
            friesCount = 0;

            grandTotalHelp = grandTotal;
             
        }




    }
}
