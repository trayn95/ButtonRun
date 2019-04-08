using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (i < 60)
            {
                Random r = new Random();
                int w = r.Next(this.ClientSize.Width - button1.Size.Width);
                int h = r.Next(this.ClientSize.Height - button1.Size.Height);
                this.button1.Location = new System.Drawing.Point(w, h);
            }
            else if (i > 60)
            {

            }



        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int w = this.Size.Width - label1.Size.Width;
            int h = this.Size.Height - label1.Size.Height;
            int x = r.Next(0, w);
            int y = r.Next(0, h);
            label1.Location = new Point(x, y);
            i++;
        }
    }
}
