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
    public partial class sign_up_frm : Form
    {
        public sign_up_frm()
        {
            InitializeComponent();
        }
          
        private void sign_up_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.gmail.com");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.gmail.com");

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
                if (!File.Exists(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt"))
                {
                    //  File.Create(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt");
                   
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt");
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.Close();
                    

                    MessageBox.Show("Cearte Account Successfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Account is already exist","Attention",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    this.Close();
                }
                this.Visible = false;
                acc_frm frm = new acc_frm(textBox1.Text);
                frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
