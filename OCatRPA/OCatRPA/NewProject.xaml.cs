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

namespace OCatRPA
{
    /// <summary>
    /// Логика взаимодействия для NewProject.xaml
    /// </summary>
    public partial class NewProject : Window
    {
        public bool UpdateInForm = false;

        public NewProject()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
        private void text_Border_TextChanged(object sender, RoutedEventArgs e)
        {
            UpdateInForm = true;
        }

        private void ExitForm_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateInForm)
            {
                MessageBoxResult result = MessageBox.Show("Сохранить изменения?", "Внимание",
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    // Сохраняем
                }
                else if (result == MessageBoxResult.No)
                {
                    Application.Current.Shutdown();
                }
            }
        }
    }
}
