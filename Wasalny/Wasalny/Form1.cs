using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wasalny
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 30)
            {
                this.Visible = false;
                timer1.Stop();
                start_frm frm = new start_frm();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                progressBar1.Value++;
               
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
