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
        public string IfBlockSet
        {
            get { return BlockNameVar.Text; }
            set { BlockNameVar.Text = value; }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
        }

         private void ApplyFlow_Click(object sender, RoutedEventArgs e)
        {
              FlowControl fcl = new FlowControl();
              if (blockIfFlow.IsChecked == true)
              {
                  fcl.BlogIfFlow();
              }
              if (BlockForFlow.IsChecked == true)
              {
                NewProject nwp = new NewProject();
                nwp.ListBox.AppendText(BlockNameVar.Text + "=" + StringVar.Text + Environment.NewLine);
                this.Close();
               }
           /* else if (blockIfFlow.IsChecked == false)
              {
                  MessageBoxResult result = MessageBox.Show("Не выбран оператор цикла", "ВНИМАНИЕ",
                  MessageBoxButton.OK,
                  MessageBoxImage.Warning);
                  if (result == MessageBoxResult.OK)
                  {
                      this.Close();
                  }
              }
             */ 
        }
    }
}
