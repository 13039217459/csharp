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
                fileplace = openFileDialog1.FileName;
                StreamReader objReader = new StreamReader(fileplace,System.Text.Encoding.Default);
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
            if (fileplace!= null)
            {
                sn = test.Text;
                StreamWriter objwriter = new StreamWriter(fileplace);
                objwriter.WriteLine(sn);
                objwriter.Close();
            }
            else
            {
                sn = test.Text;
                saveFileDialog1.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
                saveFileDialog1.ShowDialog();
                string ls = saveFileDialog1.FileName;
                StreamWriter objwriter = new StreamWriter(ls,true ,System.Text.Encoding.Default);

                for (int i = 0; i < test.Lines.Length; i++)
                {
                    objwriter.WriteLine(sn);
                }
                   
                filename = ls;
                objwriter.Close();
                // objwriter.
            }
            this.Text = filename;

        }

        private void linchunwei_Click(object sender, EventArgs e)
        {
            sn = test.Text;
            saveFileDialog1.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            string ls = saveFileDialog1.FileName;
            StreamWriter objwriter = new StreamWriter(ls, true, System.Text.Encoding.Default);

            for (int i = 0; i < test.Lines.Length; i++)
            {
                objwriter.WriteLine(sn);
            }

            filename = ls;
            objwriter.Close();
            // objwriter.


        }

       
    }
}
