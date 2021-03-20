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
    /// Логика взаимодействия для BlockVariables.xaml
    /// </summary>
    public partial class BlockVariables : Window
    {
        public BlockVariables()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
        }

         private void ApplyFlow_Click(object sender, RoutedEventArgs e)
        {
            NewProject np = new NewProject();
            if (blockIfFlow.IsChecked == true)
                {
                np.ListBox.AppendText(BlockNameVar.Text + "=" + StringVar + Environment.NewLine);
            }
        }
    }
}
