using OCatRPA;
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
        BlockVariables bkv = new BlockVariables();
        public void FlowBlockCtrl(string blcif, string blc4, string blcwh)
        {
            this.BlockIf = blcif;
            this.BlockFor = blc4;
            this.BlockWhile = blcwh;
        }
        public void BlogIfFlow()
        {
            string blcif = "if";
            ListBox.AppendText(blcif + Environment.NewLine);
            ListBox.AppendText(bkv.BlockNameVar.Text + "=" + bkv.StringVar.Text + Environment.NewLine);
        }
    }
}
