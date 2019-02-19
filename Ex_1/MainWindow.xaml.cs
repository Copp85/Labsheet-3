using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ex_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expenses> incurredExpenses = new ObservableCollection<Expenses>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expenses exp1 = new Expenses() { Name = "Fuel", Cost = 100m, IncurredDate = new DateTime (2019, 01, 15) };
            Expenses exp2 = new Expenses() { Name = "Lunch", Cost = 50m, IncurredDate = new DateTime(2019, 01, 23) };
            Expenses exp3 = new Expenses() { Name = "Stationary", Cost = 25m, IncurredDate = new DateTime(2019, 02, 04) };

            
            incurredExpenses.Add(exp1);
            incurredExpenses.Add(exp2);
            incurredExpenses.Add(exp3);

            lbxExp.ItemsSource = incurredExpenses;

            //Get total
            totalExpBlk.Text = "Total is " + GetTotalExp().ToString();
        }

        //Add another expense
        private void AddExpeBtn_Click(object sender, RoutedEventArgs e)
        {
            //Create new employee
            Expenses nextExp = new Expenses() { Name = "Electricity", Cost = 150m, IncurredDate = DateTime.Now };
            incurredExpenses.Add(nextExp);

            //Read Expenses
            totalExpBlk.Text = "Total is " + GetTotalExp().ToString();


        }

        private decimal GetTotalExp()
        {
            decimal total = 0;
            foreach (Expenses money in incurredExpenses)
            {
                total += money.Cost;
            }
            return total;
        }
    }
}
