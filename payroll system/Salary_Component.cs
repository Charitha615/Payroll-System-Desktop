using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payroll_system
{
    public partial class Salary_Component : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;
        public Salary_Component()
        {
            InitializeComponent();
        }

        private void Salary_Component_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, emp_name_comboBox001, "emp_name", "employee");
        }

        private void emp_name_comboBox001_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (emp_name_comboBox001.SelectedItem == null)
                {
                    // Code to execute when a selection is made
                    MessageBox.Show("Please Select a Employee");
                }
                else
                {
                    //Date Calculate

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
                    textBox1.Text = numberOfDays.ToString();



                    //no_pay_val
                    int noOfMonthSalary = 0;
                    int.TryParse(mon_salary_textBox2.Text, out noOfMonthSalary);

                    int noOfAllowance = 0;
                    int.TryParse(allow_textBox2.Text, out noOfAllowance);

                    int Nopayvalue =( (noOfMonthSalary + noOfAllowance) / numberOfDays) * noOfLeaves;

                    no_pay_val_textBox3.Text = Nopayvalue.ToString();

                    //Base Pay value 

                    int overhours = 1;
                    int.TryParse(over_hours_textBox1.Text, out overhours);

                    int overrate = 1;
                    int.TryParse(over_rate_textBox1.Text, out overrate);

                    int BasePayValue = noOfMonthSalary + noOfAllowance + (overrate * overhours); ;
                    base_pay_textBox4.Text = BasePayValue.ToString();

                    //Gross Pay 
                    
                    int govRate = 1;
                    int.TryParse(textBox2.Text, out govRate);

                    int GrossPay = BasePayValue - (Nopayvalue + BasePayValue * govRate);

                    gross_pay_textBox5.Text = GrossPay.ToString();
                }
            }
            catch { }
        }
    }
}
