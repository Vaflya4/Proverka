using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Characteristic : Form
    {
        public Characteristic()
        {
            InitializeComponent();
            
            Processor.Text = GetHardwareInfo("Win32_Processor", "Name").FirstOrDefault();
            Proizvoditel.Text = GetHardwareInfo("Win32_Processor", "Manufacturer").FirstOrDefault();
            Opisanie.Text = GetHardwareInfo("Win32_Processor", "Description").FirstOrDefault();
            Videokarta.Text = GetHardwareInfo("Win32_VideoController", "Name").FirstOrDefault();
            Videoprocessor.Text = GetHardwareInfo("Win32_VideoController", "VideoProcessor").FirstOrDefault();
            Versia_dravers.Text = GetHardwareInfo("Win32_VideoController", "DriverVersion").FirstOrDefault();
            Obem_pamati.Text = GetHardwareInfo("Win32_VideoController", "AdapterRAM").FirstOrDefault();
            Jestki_disk.Text = GetHardwareInfo("Win32_DiskDrive", "Caption").FirstOrDefault();
            Obem_pamati2.Text = GetHardwareInfo("Win32_DiskDrive", "Size").FirstOrDefault();
        }

        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
