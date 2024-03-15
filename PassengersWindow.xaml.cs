using System.Windows;
using PRAKTIKA_1._2;
using PRAKTIKA_1._2.DataSet1TableAdapters;
namespace PRAKTIKA_1._2
{
    public partial class PassengersWindow : Window
    {
        PassengersTableAdapter passangers = new PassengersTableAdapter();
        public PassengersWindow()
        {
            InitializeComponent();
            PassengersDataGrid.ItemsSource = passangers.GetData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            var previousWindow = new FlightsWindow();
            previousWindow.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            
            var nextWindow = new TicketsWindow();
            nextWindow.Show();
            this.Close();
        }
    }
}