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
namespace Wasalny
{
    public partial class acc_frm : Form
    {
        public acc_frm(string n)
        {
            InitializeComponent();
            label2.Text = n;
        }

        private void acc_frm_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data\\" + label2.Text + ".txt");
            label14.Text = sr.ReadLine();
            label6.Text = sr.ReadLine();
            label7.Text = sr.ReadLine();
            label11.Text = sr.ReadLine();
            label12.Text = sr.ReadLine();
            label13.Text = sr.ReadLine();
            
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            main_frm frm = new main_frm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            edit_frm frm = new edit_frm(label2.Text);
            frm.ShowDialog();
        }
    }
}
