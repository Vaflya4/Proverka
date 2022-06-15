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
    public partial class Execution : Form
    {
        public Execution()
        {
            InitializeComponent();
        }

        private void Execution_Load(object sender, EventArgs e)
        {
            using (BD_RemontEntities1 db = new BD_RemontEntities1())
            {
                var query = from lx in db.Perfomance
                            select new
                            {

                                Id_perfomance = lx.Id_perfomance,
                                Vid_Remonta = lx.Vid_Remonta,
                                Cost_of_work = lx.Cost_of_work,
                                The_cost_of_components = lx.The_cost_of_components,
                                Discount = lx.Discount,
                                The_total_cost = lx.The_total_cost,
                                Due_date = lx.Due_date
                            };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BD_RemontEntities1 db = new BD_RemontEntities1())
            {
                Perfomance sv = new Perfomance
                {
                    Vid_Remonta = textBox1.Text,
                    Cost_of_work = Convert.ToInt32(textBox2.Text),
                    The_cost_of_components = Convert.ToInt32(textBox3.Text),
                    Discount = Convert.ToInt32(textBox4.Text),
                    The_total_cost = Convert.ToInt32(textBox5.Text),
                    Due_date = Convert.ToDateTime(dateTimePicker1.Text),
                };
                db.Perfomance.Add(sv);
                db.SaveChanges();
                MessageBox.Show("Отчет отправлен");
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            textBox1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            textBox1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            textBox1.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
            textBox1.Clear();
        }
    }
}