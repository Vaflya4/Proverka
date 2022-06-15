using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MySqlX.XDevAPI.Common;

namespace WindowsFormsApp1
{
    public partial class Home2 : Form
    {
        BD_RemontEntities1 db = new BD_RemontEntities1();

        public Home2()
        {
            InitializeComponent();


            var query = from x in db.Booking
                        select new
                        {
                            Id_klient = x.Id_klient,
                            FIO = x.FIO,
                            Adress = x.Adress,
                            Phone = x.Phone,
                            Date = x.Date,
                            Description = x.Description
                        };

            dataGridView1.DataSource = query.ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Zaivki()
        {
            BD_RemontEntities1 db = new BD_RemontEntities1();

            var query = from x in db.Booking
                        select new
                        {
                            Id_klient = x.Id_klient,
                            FIO = x.FIO,
                            Adress = x.Adress,
                            Phone = x.Phone,
                            Date = x.Date,
                            Description = x.Description
                        };

            dataGridView1.DataSource = query.ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {//добавить
            Execution frm7 = new Execution();
            frm7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {//закрыть
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {//обновить
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            var query = from x in db.Booking
                        select new
                        {
                            Id_klient = x.Id_klient,
                            FIO = x.FIO,
                            Adress = x.Adress,
                            Phone = x.Phone,
                            Date = x.Date,
                            Description = x.Description
                        };
            dataGridView1.DataSource = query.ToList();
            Zaivki();
        }

        private void button4_Click(object sender, EventArgs e)
        {//удалить
            int del = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (BD_RemontEntities1 db = new BD_RemontEntities1())
            {
                Booking row = db.Booking.FirstOrDefault(d => d.Id_klient == del);
                db.Booking.Remove(row);
                db.SaveChanges();
            }
            Zaivki();
        }

        private void Home2_Load(object sender, EventArgs e)
        {
            Zaivki();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var Sortresult = result.OrderBy(u => u.FIO).ToList<>();
            //dataGridView1.DataSource = Sortresult;
            //dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
