using System.Windows;
using PRAKTIKA_1._2;
using PRAKTIKA_1._2.DataSet1TableAdapters;
namespace PRAKTIKA_1._2
{
    public partial class TicketsWindow : Window
    {
        TicketsTableAdapter tickets = new TicketsTableAdapter();
        public TicketsWindow()
        {
            InitializeComponent();
            TicketsDataGrid.ItemsSource = tickets.GetData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            var previousWindow = new PassengersWindow();
            previousWindow.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            
            var nextWindow = new FlightsWindow();
            nextWindow.Show();
            this.Close();
        }
    }
}