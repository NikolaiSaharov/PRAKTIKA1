using System.Windows;
using PRAKTIKA_1._2;
using PRAKTIKA_1._2.DataSet1TableAdapters;
namespace PRAKTIKA_1._2
{
    public partial class FlightsWindow : Window
    {
        FlightsTableAdapter flights = new FlightsTableAdapter();
        public FlightsWindow()
        {
            InitializeComponent();
           FlightsDataGrid.ItemsSource = flights.GetData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            var previousWindow = new PassengersWindow();
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