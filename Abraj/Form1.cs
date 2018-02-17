using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abraj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            string s = textBox1.Text + textBox2.Text;
            char[] prj = s.ToCharArray();
            for(int i = 0; i < prj.Length; i++)
            {
                if (prj[i]=='ا')
                {
                    c +=1;
                }
                else if (prj[i] == 'ب')
                {
                    c += 2;
                }
                else if (prj[i] == 'ج')
                {
                    c += 3;
                }
                else if (prj[i] == 'د')
                {
                    c += 4;
                }
                else if (prj[i] == 'ه')
                {
                    c += 5;
                }
                else if (prj[i] == 'و')
                {
                    c += 6;
                }
                else if (prj[i] == 'ز')
                {
                    c += 7;
                }
                else if (prj[i] == 'ح')
                {
                    c += 8;
                }
                else if (prj[i] == 'ط')
                {
                    c += 9;
                }
                else if (prj[i] == 'ي')
                {
                    c += 10;
                }
                else if (prj[i] == 'ك')
                {
                    c += 20;
                }
                else if (prj[i] == 'ل')
                {
                    c += 30;
                }
                else if (prj[i] == 'م')
                {
                    c += 40;
                }
                else if (prj[i] == 'ن')
                {
                    c += 50;
                }
                else if (prj[i] == 'س')
                {
                    c += 60;
                }
                else if (prj[i] == 'ع')
                {
                    c += 70;
                }
                else if (prj[i] == 'ف')
                {
                    c += 80;
                }
                else if (prj[i] == 'ص')
                {
                    c += 90;
                }
                else if (prj[i] == 'ق')
                {
                    c += 100;
                }
                else if (prj[i] == 'ر')
                {
                    c += 200;
                }
                else if (prj[i] == 'ش')
                {
                    c += 300;
                }
                else if (prj[i] == 'ت')
                {
                    c += 400;
                }
                else if (prj[i] == 'ث')
                {
                    c += 500;
                }
                else if (prj[i] == 'خ')
                {
                    c += 600;
                }
                else if (prj[i] == 'ذ')
                {
                    c += 700;
                }
                else if (prj[i] == 'ض')
                {
                    c += 800;
                }
                else if (prj[i] == 'ظ')
                {
                    c += 900;
                }
                else if (prj[i] == 'غ')
                {
                    c += 1000;
                }
                else if (prj[i] == 'ء')
                {
                    c += 0;
                }
                else if (prj[i] == 'ة')
                {
                    c += 5;
                }
                else if (prj[i] == 'ى')
                {
                    c += 1;
                }
                else
                {
                    c += 0;
                }
            }
            if (c % 12==0)
            {

            }
            else if (c % 12 == 1)
            {

            }
            else if (c % 12 == 2)
            {

            }
            else if (c % 12 == 3)
            {

            }
            else if (c % 12 == 4)
            {

            }
            else if (c % 12 == 5)
            {

            }
            else if (c % 12 == 6)
            {

            }
            else if (c % 12 == 7)
            {
                label3.Text = "الميزان";
            }
            else if (c % 12 == 8)
            {

            }
            else if (c % 12 == 9)
            {

            }
            else if (c % 12 == 10)
            {

            }
           
            else 
            {

            }
           // label3.Text = Convert.ToString (c%12);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
