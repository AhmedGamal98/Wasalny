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
    public partial class edit_frm : Form
    {
        public edit_frm(string n)
        {
            InitializeComponent();
            label2.Text = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + "\\data\\" + label2.Text + ".txt");
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\data\\" + textBox1.Text + ".txt");
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox6.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox3.Text);
            sw.Close();
            MessageBox.Show("Update successfully");
            this.Visible = false;
            start_frm frm = new start_frm();
            frm.ShowDialog();
        }

        private void edit_frm_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data\\" + label2.Text + ".txt");
            textBox5.Text = sr.ReadLine();
            textBox1.Text = sr.ReadLine();
            textBox2.Text = sr.ReadLine();
            textBox6.Text = sr.ReadLine();
            textBox4.Text = sr.ReadLine();
            textBox3.Text = sr.ReadLine();

            sr.Close();
        }
    }
}
