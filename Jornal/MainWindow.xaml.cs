using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Jornal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FileWorkers = "workers.json";
        private List<Worker> workers = new List<Worker>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemAddWorkerClick(object sender, RoutedEventArgs e)
        {
            new AddWorkerView(workers).ShowDialog();
        }

        private void MenuItemAddHoursWorkerClick(object sender, RoutedEventArgs e)
        {
            new AddHoursWorker(workers).ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FileStream file = null;

            try
            {
                file = File.Open(FileWorkers, FileMode.OpenOrCreate);
                var reader = new StreamReader(file);
                workers = JsonConvert.DeserializeObject<List<Worker>>(reader.ReadToEnd());                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                    file.Dispose();
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            FileStream file = null;

            try
            {
                file = File.Open(FileWorkers, FileMode.OpenOrCreate);
                var writer = new StreamWriter(file);
                var writeJson = JsonConvert.SerializeObject(workers);
                writer.WriteLine(writeJson);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                    file.Dispose();
                }
            }
        }
    }
}
