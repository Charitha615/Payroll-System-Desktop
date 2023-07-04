using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Open Reservation Screeen
            //blur_imagebox.Visible = true;
            Form1 emp_screen = new Form1();
            emp_screen.ShowDialog();
            //blur_imagebox.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Settings_componets emp_screen = new Settings_componets();
            emp_screen.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Salary_Component emp_screen = new Salary_Component();
            emp_screen.ShowDialog();
        }
    }
}
