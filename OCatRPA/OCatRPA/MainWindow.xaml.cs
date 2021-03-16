using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;

namespace OCatRPA
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            NewProject nprj = new NewProject();
            nprj.Show();
            
        }

        private void AddProjectRP_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NewProject nprj = new NewProject();
            nprj.Show();
        }

        private void OpenProjectButton_Click(object sender, RoutedEventArgs e)
        {
            fileDialog opd = new fileDialog();
            opd.OpenDialogStartPage();
        }

        private void OpenFileRP_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fileDialog opd = new fileDialog();
            opd.OpenDialogStartPage();
        }
    }
}
