using Microsoft.Win32;
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

namespace BindingTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string path = null;
        public MainWindow()
        {
            InitializeComponent();
            var colors = new List<string> { "Red", "Black", "Yellow", "Green", "blue", "Orange", "White" };
            Select_Color.ItemsSource = colors;
            var fontSize = new List<double> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26 };
            Font_Size.ItemsSource = fontSize;
            var colorBox = new List<string> { "White", "Black", "Red", "Yellow", "Green", "blue", "Orange" };
            ColorBox.ItemsSource = colorBox;
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            var pathFile = OpenFile();
            TextFile.Text = File.ReadAllText(pathFile);
            //path = pathFile;
        }

        /*private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            FileDialogues.SaveAsFile(TextFile.Text, out string pathFile);
            //path = pathFile;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            /*if (path == null)
            {
                FileDialogues.SaveAsFile(TextFile.Text, out string pathFile);
                path = pathFile;
                return;
            }
            File.WriteAllText(path, TextFile.Text);
        }*/
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public static string OpenFile()
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                pathFile = openFileDialog.FileName;
                return File.ReadAllText(pathFile); 
            }
            pathFile = null;
            return String.Empty;*/
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : string.Empty;
        }
    }
}
