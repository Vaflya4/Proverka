using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Windows.UI.Xaml.Controls;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Characteristic frm6 = new Characteristic();
            frm6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application frm3 = new Application();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrator frm4 = new Administrator();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Information frm8 = new Information();
            frm8.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.link/repaircomputer_1");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/repaircomputer_1");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
    }
}
