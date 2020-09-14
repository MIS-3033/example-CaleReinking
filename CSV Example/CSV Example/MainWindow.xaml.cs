using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSV_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = txtFilePath.Text;

            if (File.Exists(FilePath) == true)
            {
                btnProcess.IsEnabled = true;
                btnSelectFile.IsEnabled = false;
                txtFilePath.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Invalid file, please try again, Error. MessageBoxButton.OK");
                txtFilePath.Text = "";
               // txtFilePath.Focus;
            }
            
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = txtFilePath.Text;
            var lines = File.ReadAllLines(FilePath);
            // foreach (var line in lines)
            // {
            //  1stLines.Item.Add(line);

            // }
            double sum = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                var pieces = lines[i].Split(',');
                double val;

                bool success = double.TryParse(pieces[2], out val);
                if (success == false)
                {
                    MessageBox.Show("Error on lines " + i);
                }
                else
                {
                    sum += val;
                } 
                lstLines.Items.Add(pieces[1]);
                //Convert.ToDouble(pieces[2]);
                // sum += Convert.ToDouble(pieces[2]);
                //lstLines.Items.Add(line);
                
            }

        }
    }
}
