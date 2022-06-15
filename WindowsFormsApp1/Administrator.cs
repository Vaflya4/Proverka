using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Windows.System;

namespace WindowsFormsApp1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home2 user = new Home2();
            switch (textBox1.Text + textBox2.Text)
            {
                case "Admin" + "Diplom4321":
                    user.Show();
                    break;
                default:
                    MessageBox.Show("Неправильный логин или пароль!!!");
                    break;
            }
        }
    }
}
