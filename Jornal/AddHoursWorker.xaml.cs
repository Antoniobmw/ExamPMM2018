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

namespace Jornal
{
    /// <summary>
    /// Interaction logic for AddHoursWorker.xaml
    /// </summary>
    public partial class AddHoursWorker : Window
    {
        private List<Worker> workers;

        public AddHoursWorker(List<Worker> workers)
        {
            InitializeComponent();

            this.workers = workers;
            ListBoxWorkers.ItemsSource = workers;
        }

        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAcceptClick(object sender, RoutedEventArgs e)
        {
            if(ListBoxWorkers.SelectedIndex != -1)
            {
                var worker = (Worker)ListBoxWorkers.SelectedItem;

                int hours = 0;
                int.TryParse(TextBoxHours.Text, out hours);

                worker.Hours += hours;
            }
        }
    }
}
