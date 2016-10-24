using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 记事本程序
{
    public partial class Form1 : Form
    {

        string filename ;
        string fileplace;
        string sn;


        public Form1()
        {
            InitializeComponent();
        }

        private void xinjian_Click(object sender, EventArgs e)
        {
            test.Clear();
            fileplace = null;
            filename = "未标题";
        }

        private void dakai_Click(object sender, EventArgs e)
        {
            test.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ls = openFileDialog1.FileName;
                this.Text = ls;
                filename = openFileDialog1.FileName;
                StreamReader objReader = new StreamReader(filename);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        test.Text = test.Text + sLine;
                }
                 objReader.Close();
            }


        }

        private void baochun_Click(object sender, EventArgs e)
        {
            if (filename != null)
            {
                StreamWriter objwriter = new StreamWriter(filename);
                objwriter.WriteLine(sn);
                objwriter.Close();
            }
            else
            {
                saveFileDialog1.ShowDialog();
                string ls = saveFileDialog1.FileName;
                StreamWriter objwriter = new StreamWriter(ls);
                objwriter.WriteLine(sn);
                filename = ls;
                objwriter.Close();
                // objwriter.
            }
            this.Text = filename;

        }

        private void linchunwei_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string ls = saveFileDialog1.FileName;
            StreamWriter objwriter = new StreamWriter(ls);
            objwriter.WriteLine(sn);
            //resultFile = ls;
            objwriter.Close();


        }

       
    }
}
