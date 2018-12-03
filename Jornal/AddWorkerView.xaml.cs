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
    /// Interaction logic for AddWorkerView.xaml
    /// </summary>
    public partial class AddWorkerView : Window
    {
        private List<Worker> workers;

        public AddWorkerView(List<Worker> workers)
        {            
            InitializeComponent();
            this.workers = workers;
        }

        private void ButtonAcceptClick(object sender, RoutedEventArgs e)
        {
            if(!LabelContentName.IsEmpty() &&
               !LabelContentSurname.IsEmpty() &&
               !LabelContentId.IsEmpty() &&
               !LabelContentCostHour.IsEmpty())
            {
                double costHour = 0;
                double.TryParse(LabelContentCostHour.TextBoxTextValue, out costHour);
                
                workers.Add(new Worker()
                {
                    Id = LabelContentId.TextBoxTextValue,
                    Name = LabelContentName.TextBoxTextValue,
                    Surname = LabelContentSurname.TextBoxTextValue,
                    CostHour = costHour
                });
            }
            else
            {
                MessageBox.Show("Esta vacio!!!");
            }
        }


        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
