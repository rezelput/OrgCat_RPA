using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCatRPA
{
    class saveDialog : NewProject
    {
        Microsoft.Win32.SaveFileDialog SaveFile;
        string name;

        public void SaveFileNewPrj()
        {
            SaveFile = new Microsoft.Win32.SaveFileDialog();
            SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFile.FilterIndex = 2;
            SaveFile.RestoreDirectory = true;
            if (SaveFile.ShowDialog() == true)
            {
                name = SaveFile.FileName;
              //  File.WriteAllText(name,/* textBox1.Text */BorderProject.); //сохранение проекта 
            }
        }
    }
}
