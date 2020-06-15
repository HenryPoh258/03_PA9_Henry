using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Henry_PA9
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click (object sender, EventArgs e)
        {
            decimal US = 0.74m;
            decimal Japan = 81.97m;
            decimal Malaysia = 3.01m;

            decimal answer;

            try
            {
                decimal first = Convert.ToDecimal(txt_Amount.Text);

                if (first <= 0)
                {
                    MessageBox.Show("Please Enter A Valid Amount.");
                }
                else if (rb_US.Checked)
                {
                    answer = first * US;
                    txt_Converted.Text = answer.ToString();
                }
                else if (rb_Yen.Checked)
                {
                    answer = first * Japan;
                    txt_Converted.Text = answer.ToString();
                }

                else if (rb_Ringgit.Checked)
                {
                    answer = first * Malaysia;
                    txt_Converted.Text = answer.ToString();
                }

                else
                {
                    MessageBox.Show("Please select one of the currency");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount");
            }
        }

        private void btn_Clear_Click (object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
            rb_Ringgit.Checked = false;
        }

        private void Rb_Ringgit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
