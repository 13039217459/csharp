namespace 记事本程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wenjian = new System.Windows.Forms.ToolStripMenuItem();
            this.xinjian = new System.Windows.Forms.ToolStripMenuItem();
            this.dakai = new System.Windows.Forms.ToolStripMenuItem();
            this.baochun = new System.Windows.Forms.ToolStripMenuItem();
            this.linchunwei = new System.Windows.Forms.ToolStripMenuItem();
            this.test = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wenjian});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wenjian
            // 
            this.wenjian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinjian,
            this.dakai,
            this.baochun,
            this.linchunwei});
            this.wenjian.Name = "wenjian";
            this.wenjian.Size = new System.Drawing.Size(51, 24);
            this.wenjian.Text = "文件";
            // 
            // xinjian
            // 
            this.xinjian.Name = "xinjian";
            this.xinjian.Size = new System.Drawing.Size(129, 26);
            this.xinjian.Text = "新建";
            this.xinjian.Click += new System.EventHandler(this.xinjian_Click);
            // 
            // dakai
            // 
            this.dakai.Name = "dakai";
            this.dakai.Size = new System.Drawing.Size(129, 26);
            this.dakai.Text = "打开";
            this.dakai.Click += new System.EventHandler(this.dakai_Click);
            // 
            // baochun
            // 
            this.baochun.Name = "baochun";
            this.baochun.Size = new System.Drawing.Size(129, 26);
            this.baochun.Text = "保存";
            this.baochun.Click += new System.EventHandler(this.baochun_Click);
            // 
            // linchunwei
            // 
            this.linchunwei.Name = "linchunwei";
            this.linchunwei.Size = new System.Drawing.Size(129, 26);
            this.linchunwei.Text = "另存为";
            this.linchunwei.Click += new System.EventHandler(this.linchunwei_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(25, 45);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(842, 411);
            this.test.TabIndex = 1;
            this.test.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 463);
            this.Controls.Add(this.test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wenjian;
        private System.Windows.Forms.ToolStripMenuItem xinjian;
        private System.Windows.Forms.ToolStripMenuItem dakai;
        private System.Windows.Forms.ToolStripMenuItem baochun;
        private System.Windows.Forms.ToolStripMenuItem linchunwei;
        private System.Windows.Forms.RichTextBox test;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

