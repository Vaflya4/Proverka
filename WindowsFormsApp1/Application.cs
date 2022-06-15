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
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            using (BD_RemontEntities1 db = new BD_RemontEntities1())
            {
                var query = from cl in db.Booking
                            select new
                            {
                                Id_klient = cl.Id_klient,
                                FIO = cl.FIO,
                                Adress = cl.Adress,
                                Phone = cl.Phone,
                                Date = cl.Date,
                                Description = cl.Description
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BD_RemontEntities1 db = new BD_RemontEntities1())
            {
                Booking st = new Booking
                {
                    FIO = textBox1.Text,
                    Adress = textBox2.Text,
                    Phone = textBox3.Text,
                    Date = Convert.ToDateTime(dateTimePicker1.Text),
                    Description = textBox4.Text
                };
                db.Booking.Add(st);
                db.SaveChanges();
                MessageBox.Show("Заявка отправлена. Ожидайте мастера.");
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
