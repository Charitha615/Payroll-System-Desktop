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

namespace payroll_system
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = DBUtil.get_DBConnection(); //Get Connetion

        String sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComponentClass.add_To_Combo(connection, emp_name_comboBox1, "emp_name", "employee");
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try {
                //Open the connection
                DBUtil.open_Connection(connection);



                //SQL Command
                sql = $"INSERT INTO `payroll_system`.`employee` ( `emp_name`, `mon_salary`, `hourly_rate`, `allowance`, `contact_number`) VALUES('{emp_name_comboBox1.Text}', '{mon_salary_textBox2.Text}', '{houre_rate_textBox1.Text}', '{allow_textBox2.Text}', '{contact__textBox1.Text}')";

                MySqlCommand my = new MySqlCommand(sql, connection);
                my.ExecuteNonQuery();
                MessageBox.Show("Success Your Submission!");
                connection.Close();
                my.Dispose();

                foreach (Control c in groupBox1.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                    else if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }

                ComponentClass.add_To_Combo(connection, emp_name_comboBox1, "emp_name", "employee");
                //Combo Box Load
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.ToString());
            }
        }

        private void emp_name_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                DBUtil.open_Connection(connection);

                //Sql Commands
                sql = $"SELECT * FROM employee WHERE emp_name='{emp_name_comboBox1.SelectedItem}'";
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            //Open connection
            DBUtil.open_Connection(connection);

            //SQL
            sql = $" DELETE FROM employee WHERE emp_name='{emp_name_comboBox1.SelectedItem}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Successfully Deleted ");

            connection.Close();
            my.Dispose();

            ComponentClass.add_To_Combo(connection, emp_name_comboBox1, "emp_name", "employee");

            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                else if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            DBUtil.open_Connection(connection);


            sql = $"UPDATE employee SET mon_salary= '{mon_salary_textBox2.Text}',hourly_rate= '{houre_rate_textBox1.Text}',allowance= '{allow_textBox2.Text}',contact_number= '{contact__textBox1.Text}' WHERE emp_name= '{emp_name_comboBox1.SelectedItem}'";
            MySqlCommand my = new MySqlCommand(sql, connection);
            my.ExecuteNonQuery();

            MessageBox.Show("Employee Details Updated");

            connection.Close();
            my.Dispose(); // clear the data stored in the object "my"


            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                else if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            //Add to combobox
            ComponentClass.add_To_Combo(connection, emp_name_comboBox1, "emp_name", "employee");
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
