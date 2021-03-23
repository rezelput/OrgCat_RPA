using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCatRPA
{
    class LoadFilePrj:NewProject
    {

        public void LoadFiletoPrjc()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog(); 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            { 
                string filename = dlg.FileName;
                ProgBar_Flow.Value = 100;
                StreamReader rdr = new StreamReader(dlg.FileName, Encoding.Default);
                ListBox.AppendText(rdr.ReadToEnd());
                rdr.Close();
            }
        }
    }
}
