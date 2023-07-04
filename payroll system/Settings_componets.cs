using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payroll_system
{
    public partial class Settings_componets : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;
        public Settings_componets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                DateTime selectedDate = dateTimePicker2.Value.Date;
                DateTime selectedTime = dateTimePicker1.Value.Date;

                // Calculate the difference in days
                TimeSpan difference = selectedDate - selectedTime;
                int numberOfDays = difference.Days;

                // Retrieve the value from no_of_leaves__textBox1
                int noOfLeaves = 0;
                int.TryParse(no_of_leaves__textBox1.Text, out noOfLeaves);

                // Subtract noOfLeaves from numberOfDays
                numberOfDays -= noOfLeaves;

                // Display the updated result in textBox2
                textBox2.Text = numberOfDays.ToString();
            }
            catch {
          
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                DBUtil.open_Connection(connection);

                //Sql Commands
                sql = $"SELECT * FROM employee WHERE emp_name='{emp_name_comboBox001.SelectedItem}'";
                MySqlCommand my = new MySqlCommand(sql, connection);
                MySqlDataReader reader; //default
                reader = my.ExecuteReader();  //store the data


                //Get the values using loop
                while (reader.Read())
                {
                    mon_salary_textBox2.Text = reader.GetString(2);
                    houre_rate_textBox1.Text = reader.GetString(3);
                    allow_textBox2.Text = reader.GetString(4);
                    contact__textBox1.Text = reader.GetString(5);

                }


                connection.Close();
                my.Dispose();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrive Combox Values Error" + ex.ToString());
            }
        }

        private void Settings_componets_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, emp_name_comboBox001, "emp_name", "employee");
        }
    }
}
