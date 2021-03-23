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
            saveDialog smv = new saveDialog();
            smv.SaveFileNewPrj();
        }
        private void text_Border_TextChanged(object sender, RoutedEventArgs e)
        {
            UpdateInForm = true;
        }

        private void ExitForm_Click(object sender, RoutedEventArgs e)
        {
                    MessageBoxResult result = MessageBox.Show("Сохранить изменения?", "Внимание",
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    saveDialog smv = new saveDialog();
                    smv.SaveFileNewPrj();
                }
                else if (result == MessageBoxResult.No)
                {
                    Application.Current.Shutdown();
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text_begin = "begin";
            ListBox.AppendText( text_begin + Environment.NewLine);

        }

        private void ButtonEnd_Click(object sender, RoutedEventArgs e)
        {
            string text_end = "end";
            ListBox.AppendText(text_end + Environment.NewLine);
        }
        private void ClearListBox_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Clear();
        }

        private void IfClick_Click(object sender, RoutedEventArgs e)
        {
            BlockVariables bkv = new BlockVariables();
            bkv.Show();

        }

        private void BtnForClick_Click(object sender, RoutedEventArgs e)
        {
            string blv_for = "for";
            BlockVariables bkv = new BlockVariables();
            ListBox.AppendText(blv_for + Environment.NewLine);
            bkv.Show();
        }

        private void BtnWhileClick_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadProg_Click(object sender, RoutedEventArgs e)
        {
            LoadFilePrj flg = new LoadFilePrj();
            flg.LoadFiletoPrjc();
        }
    }
}
