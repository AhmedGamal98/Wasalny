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

    public partial class main_frm : Form
    {
        public main_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_frm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string line = " ";
            string[] s = { "عين_حلوان", "حلوان", "جامعة_حلوان", "وادي_حوف", "حدايق_حلوان", "طرة_الاسمنت", "كوتسيكا", "طرة_البلد", "ثكنات_المعادي", "المعادي", "حدايق_المعادي" };
            for (int i = 0; i <= s.Length - 1; i++)
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\stations\\" + s[i] + ".txt");
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line == textBox1.Text)
                    {
                        if (s[i] == "حلوان")
                        {
                            حلوان.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "عين_حلوان")
                        {
                            عين_حلوان.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "جامعة_حلوان")
                        {
                            جامعة_حلوان.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "وادي_حوف")
                        {
                            وادي_حوف.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "حدايق_حلوان")
                        {

                            حدايق_حلوان.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "طرة_الاسمنت")
                        {
                            طرة_الاسمنت.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "كوتسيكا")
                        {
                            كوتسيكا.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "طرة_البلد")
                        {
                            textBox3.Text = s[i];
                            طرة_البلد.Checked = true;

                        }
                        else if (s[i] == "ثكنات_المعادي")
                        {
                            ثكنات_المعادي.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "المعادي")
                        {
                            المعادي.Checked = true;
                            textBox3.Text = s[i];

                        }
                        else if (s[i] == "حدايق_المعادي")
                        {
                            حدايق_المعادي.Checked = true;
                            textBox3.Text = s[i];

                        }

                    }
                    //---------------------------------------------------------------------------------------------------------------
                    string line1 = " ";
                    string[] s1 = { "كوتسيكا", "عين_حلوان", "جامعة_حلوان", "وادي_حوف", "حدايق_حلوان", "طرة_الاسمنت", "حلوان", "طرة_البلد", "ثكنات_المعادي", "المعادي", "حدايق_المعادي" };
                    for (int j = 0; j <= s.Length - 1; j++)
                    {
                        StreamReader sr1 = new StreamReader(Application.StartupPath + "\\stations\\" + s1[j] + ".txt");
                        while (line1 != null)
                        {
                            line1 = sr1.ReadLine();

                            if (line1 == textBox2.Text)
                            {
                                if (s1[j] == "حلوان")
                                {
                                    حلوان.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "عين_حلوان")
                                {
                                    عين_حلوان.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "جامعة_حلوان")
                                {
                                    جامعة_حلوان.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "وادي_حوف")
                                {
                                    وادي_حوف.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "حدايق_حلوان")
                                {

                                    حدايق_حلوان.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "طرة_الاسمنت")
                                {
                                    طرة_الاسمنت.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "كوتسيكا")
                                {
                                    كوتسيكا.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "طرة_البلد")
                                {

                                    طرة_البلد.Checked = true;
                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "ثكنات_المعادي")
                                {
                                    ثكنات_المعادي.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "المعادي")
                                {
                                    المعادي.Checked = true;

                                    textBox4.Text = s1[j];
                                }
                                else if (s1[j] == "حدايق_المعادي")
                                {
                                    حدايق_المعادي.Checked = true;

                                    textBox4.Text = s1[j];
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
