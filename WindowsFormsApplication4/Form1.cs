using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar = 0;
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Kaç tane çay olduğunu girmediniz!");
                    checkBox1.Checked = false;
                }
                else
                {
                    int cay;
                    cay = Convert.ToInt32(textBox1.Text);
                    listBox1.Items.Add(cay + " Adet Çay " + cay * 0.75 + " TL");
                    tutar = tutar + cay * 0.75;
                }
            }
            if (checkBox2.Checked)
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Kaç tane kahve olduğunu girmediniz!");
                else
                {
                    int kahve;
                    kahve = Convert.ToInt32(textBox2.Text);
                    listBox1.Items.Add(kahve + " Adet Kahve " + kahve * 1 + " TL");
                    tutar = tutar + kahve * 1;
                }
            }
            if (checkBox3.Checked)
            {
                int tost;
                tost = Convert.ToInt32(textBox3.Text);
                listBox1.Items.Add(tost + " Adet Tost " + tost * 3 + " TL");
                tutar = tutar + tost * 3;
            }
            if (checkBox4.Checked)
            {
                int su;
                su = Convert.ToInt32(textBox4.Text);
                listBox1.Items.Add(su + " Adet Su " + su * 1 + " TL");
                tutar = tutar + su * 1;
            }
            if (checkBox5.Checked)
            {
                int cikolata;
                cikolata = Convert.ToInt32(textBox5.Text);
                listBox1.Items.Add(cikolata + " Adet cikolata " + cikolata * 3 + " TL");
                tutar = tutar + cikolata * 3;
            }

            if (tutar > 50)
            {
                tutar = tutar * 0.80;
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Tutarda %20 indirim yapıldı.");
                listBox1.Items.Add("Tutar = "+ tutar);
            }
            else if (tutar > 20)
            {
                tutar = tutar * 0.90;
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Tutarda %10 indirim yapıldı.");
                listBox1.Items.Add("Tutar = " + tutar);
            }
            else
            {                
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Tutar = " + tutar);     
            
            }


            
        }
    }
}
