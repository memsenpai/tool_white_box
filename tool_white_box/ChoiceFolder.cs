using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool_white_box
{
    public partial class ChoiceFolder : UserControl
    {
        public String Path;
        public DirectoryInfo Info;
        public ChoiceFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            ;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
                Path = textBox1.Text;
               Info = new DirectoryInfo(Path); 
            }
        }
    }
}
