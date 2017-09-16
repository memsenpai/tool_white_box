using System;
using System.IO;
using System.Windows.Forms;
using Css;
using System.Drawing;

namespace tool_white_box
{
    public partial class MainFrom : MetroFramework.Forms.MetroForm
    {
        private CssConventions conventions;
        public MainFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabPage tabControl1TabPage in tabControl1.TabPages)
            {
                DataGridView listView = new DataGridView();
                //listView.Enabled = false;
                listView.Columns.Add("file_name", "Name");
                listView.Columns.Add("file_path", "Path");
                listView.Columns.Add("file_error", "Error");
                listView.RowHeadersVisible = false;
                listView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabControl1TabPage.Controls.Add(listView);
                listView.Location = new Point(listView.Parent.Location.X, listView.Parent.Location.Y - 10);
                listView.Width = listView.Parent.Width - 1;
                listView.Height = listView.Parent.Height - 1;
            }
        }

        private void initMenuStrip()
        {

        }
        private void clearView()
        {
            foreach (Control c in tabCss.Controls)
            {
                if (c is DataGridView)
                {
                    DataGridView list = (DataGridView)c;
                    list.Rows.Clear();
                }
            }
            foreach (Control c in tabJs.Controls)
            {
                if (c is DataGridView)
                {
                    DataGridView list = (DataGridView)c;
                    list.Rows.Clear();
                }
            }
            foreach (Control c in tabHtml.Controls)
            {
                if (c is DataGridView)
                {
                    DataGridView list = (DataGridView)c;
                    list.Rows.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearView();
            if (cbCss.Checked)
            {
                foreach (Control c in tabCss.Controls)
                {
                    if (c is DataGridView)
                    {
                        DataGridView list = (DataGridView)c;
                        foreach (FileInfo file in ChoiceFolder1.Info.GetFiles("*.*css"))
                        {

                            //conventions = new CssConventions(file);
                            //MessageBox.Show(conventions.Notice);
                            //int index = 0;
                            //foreach (string line in File.ReadAllLines(file.FullName))
                            //{
                            //    index ++;
                            //    if (line.Contains("color:"))
                            //    {
                            //        string[] lines = line.Split(':');
                            //        if (lines[1].Contains("#"))
                            //        {
                            //            list.Rows.Add(file.Name, file.DirectoryName, "line " + index +  ": Color must declare");
                            //        }
                            //    }
                            //}
                            conventions = new CssConventions(file);
                            conventions.readFiles();
                            foreach(string a in conventions.Notice)
                            {
                                list.Rows.Add(file.Name, file.DirectoryName,a);                            }
                            
                        }
                    }
                }

            }
        }
    }
}
