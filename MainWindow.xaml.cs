using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Win32;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Threading;
using DataTable = System.Data.DataTable;
using Window = System.Windows.Window;

namespace BachelorsPhSalesProcessor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string fileLocation = "";
        private string fileName = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Process()
        {
            DataTable sales = new DataTable();

            using var reader = new StreamReader(fileLocation);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                IgnoreBlankLines = true,
                DetectColumnCountChanges = true
            });

            using var dr = new CsvDataReader(csv);
            sales.Load(dr);

            TxtRecords.Text = sales.Rows.Count.ToString();

            double count = 0;
            double inserted = 0;
            bool hasError = false;
            int errorCount = 0;

            foreach (var item in sales.Rows)
            {
                count = sales.Rows.Count;

                if (!hasError)
                {
                    inserted++;
                }
                else
                {
                    errorCount++;
                }

                double value = inserted / (count - errorCount);
                double progress = value * 100;

                Thread.Sleep(500);

                ProgProcess.Dispatcher.Invoke(() => ProgProcess.Value = progress, DispatcherPriority.Background);
            }

            string content = " record(s) has been successfully inserted.";

            if (hasError)
            {
                content = " record(s) has been successfully inserted.\nThere is/are {0} record(s) not inserted.";
                content = String.Format(content, errorCount);
            }

            MessageBox.Show((count - errorCount).ToString(CultureInfo.InvariantCulture) + content, "FINISHED",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }





        private void BtnProcess_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Start processing?", "PROCESS",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Process();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Close this application?", "CLOSE",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.DefaultExt = ".csv";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            Nullable<bool> result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string filename = openFileDialog.FileName;
                TxtFilePath.Text = filename;
                fileLocation = filename;
                fileName = filename.Split('\\')[filename.Split('\\').Length - 1];
            }
        }
    }
}
