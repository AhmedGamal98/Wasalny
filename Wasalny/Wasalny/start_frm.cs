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
    public partial class start_frm : Form
    {
        public start_frm()
        {
            InitializeComponent();
        }

        private void start_frm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            sign_up_frm frm = new sign_up_frm();
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line=" ";
            bool flag = false;
            if (File.Exists(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt");
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line == textBox2.Text)
                    {
                        flag = true;
                    }
 
                }
                if (flag == true)
                {
                    this.Visible = false;
                    acc_frm frm = new acc_frm(textBox1.Text);
                    frm.ShowDialog();
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("This Account is not exist\n 1-write correct name \n 2-Make a new account","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
