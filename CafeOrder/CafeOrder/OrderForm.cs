using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrder
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int teaNum = Convert.ToInt32(teaNumLabel.Text);
            if (teaNum > 0)
            {
                teaNum--;
                teaNumLabel.Text = Convert.ToString(teaNum);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int colaNum = Convert.ToInt32(colaNumLabel.Text);
            if (colaNum > 0)
            {
                colaNum--;
                colaNumLabel.Text = Convert.ToString(colaNum);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int coffeeNum = Convert.ToInt32(coffeeNumLabel.Text);
            if (coffeeNum > 0)
            {
                coffeeNum--;
                coffeeNumLabel.Text = Convert.ToString(coffeeNum);
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            teaNumLabel.Text = "0";
            coffeeNumLabel.Text = "0";
            colaNumLabel.Text = "0";

        }

        private void teaPlusBtn_Click(object sender, EventArgs e)
        {
            int teaNum = Convert.ToInt32(teaNumLabel.Text);
            teaNum++;
            teaNumLabel.Text=Convert.ToString(teaNum);
        }

        private void coffeePlusBtn_Click(object sender, EventArgs e)
        {
            int coffeeNum = Convert.ToInt32(coffeeNumLabel.Text);
            coffeeNum++;
            coffeeNumLabel.Text = Convert.ToString(coffeeNum);
        }

        private void colaPlusBtn_Click(object sender, EventArgs e)
        {
            int colaNum = Convert.ToInt32(colaNumLabel.Text);
            colaNum++;
            colaNumLabel.Text = Convert.ToString(colaNum);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Order Details: " + teaNumLabel.Text + " " + "Tea, " + 
                coffeeNumLabel.Text+" " +"Coffee, " + colaNumLabel.Text + " " +"Cola" );

        }
    }
}
