using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazSolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dayPerBim = 60;
            double lostFactor = 0.77;
            double parseW = 1000;


            //Getting Data Input

            string consumeBim1 = textBox1.Text;
            string consumeBim2 = textBox2.Text;
            string consumeBim3 = textBox3.Text;
            string consumeBim4 = textBox4.Text;
            string consumeBim5 = textBox5.Text;
            string consumeBim6 = textBox6.Text;

            string hours = textBox7.Text;
            string power = textBox8.Text;


            //Converting Data 

            double cdBim1 = Double.Parse(consumeBim1);
            double cdBim2 = Double.Parse(consumeBim2);
            double cdBim3 = Double.Parse(consumeBim3);
            double cdBim4 = Double.Parse(consumeBim4);
            double cdBim5 = Double.Parse(consumeBim5);
            double cdBim6 = Double.Parse(consumeBim6);

            double hoursD = Double.Parse(hours);
            double powerD = Double.Parse(power);


            //Initialing calculate 

            double avgConsume = (cdBim1 + cdBim2 + cdBim3 + cdBim4 + cdBim5 + cdBim6) / 6;
            double getEnergy = avgConsume / dayPerBim;
            double pfv = getEnergy / (hoursD * lostFactor);
            double module = pfv / (powerD / parseW);


            //Returning Result 

            textBox9.Text = module.ToString();









        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
