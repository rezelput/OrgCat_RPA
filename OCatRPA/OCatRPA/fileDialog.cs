using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace OCatRPA
{
    class fileDialog:MainWindow
    {
        Microsoft.Win32.OpenFileDialog dialog;
        NewProject nwp = new NewProject();


        public void OpenDialogStartPage()
        {
            dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.FileName = ListPathBox.Text;
            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                // Open document
                string filename = dialog.FileName;
                NewProject nwp = new NewProject();
                nwp.ListBox.Text = filename;
            }
        }
    }
}
