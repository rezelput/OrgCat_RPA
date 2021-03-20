using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCatRPA
{
    class FlowControl:NewProject
    {
        string BlockIf;
        string BlockFor;
        string BlockWhile;

        public void BlogIfFlow()
        {
            BlockVariables bkv = new BlockVariables();
            ListBox.AppendText(bkv.BlockNameVar.Text + "=" + bkv.StringVar + Environment.NewLine);
        }
    }
}
