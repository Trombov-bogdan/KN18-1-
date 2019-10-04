using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kalkylon : Form
    {
        public Kalkylon()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(multiplay(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(substract(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        public static double sum(double a, double b) //symma
        {
            return a + b;
        }
        public static double devide(double a, double b)//delenie
        {
            return a / b;
        }
        public static double substract(double a, double b)// otnum
        {
            return a - b;
        }
        public static double multiplay(double a, double b) // dob
        {
            return a * b;
        }
    }
}
