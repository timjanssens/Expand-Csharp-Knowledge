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
        const int BabyAge = 4;
        const int ChildAge = 12;

        int age = 0;
        int babyCount = 0;
        int childCount = 0;
        int adultCount = 0;
        int totalPersonsCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            age = int.Parse(txtLeeftijd.Text);
            if (age < BabyAge)
                babyCount++;
            else if (age < ChildAge)
                childCount++;
            else
                adultCount++;

            totalPersonsCount++;

            txtYoungerThan4.Text = babyCount.ToString();
            txtYoungerThan12.Text = childCount.ToString();
            txtOlderThan12.Text = adultCount.ToString();
            txtTotalPersons.Text = totalPersonsCount.ToString();

            txtLeeftijd.Focus();
            txtLeeftijd.Text = string.Empty;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNewGroup_Click(object sender, RoutedEventArgs e)
        {
            txtLeeftijd.Focus();
            txtLeeftijd.Text = string.Empty;
            txtYoungerThan4.Text = string.Empty;
            txtYoungerThan12.Text = string.Empty;
            txtOlderThan12.Text = string.Empty;
            txtTotalPersons.Text = string.Empty;
            txtTotalBill.Text = string.Empty;

            babyCount = 0;
            childCount = 0;
            adultCount = 0;
            totalPersonsCount = 0;
        }

        private void enter(object sender, KeyEventArgs e)
        {

        }
    }
}
