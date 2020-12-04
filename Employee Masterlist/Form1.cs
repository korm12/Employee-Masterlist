using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Employee_Masterlist
{
    public partial class Form1 : Form
    {
        String fname ="", lname = "", mname = "", email = "", phone = "", address = "", age = "", gender = "", status = "", nationality = "", birthday = "", birthplace = "";

        private void button7_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM personal_details WHERE emp_id ="+searchIDCMB.Text+"";

            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Record Deleted");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            String query2 = "DELETE FROM employment_history WHERE emp_id =" + searchIDCMB.Text + "";
            MySqlCommand commandQuery2 = new MySqlCommand(query2, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery2.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Record Deleted");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            String query3 = "DELETE FROM educational_attainments WHERE emp_id =" + searchIDCMB.Text + "";
            MySqlCommand commandQuery3 = new MySqlCommand(query3, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery3.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Record Deleted");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String query = "SELECT emp_id FROM personal_details order by emp_id DESC";
            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;
            searchIDCMB.Items.Clear();
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        searchIDCMB.Items.Add(myReader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String query = "";
            school = schoolT.Text;
            schoolAddress = schoolAddressT.Text;
            course = courseT.Text;
            dateCompleted = dateCompletedT.Text;


            query = "UPDATE educational_attainments SET school ='" + school + "'," +
               "schoolAddress='" + schoolAddress + "'," +
               "course='" + course + "'," +
               "dateCompleted='" + dateCompleted +"'"+
               "WHERE emp_id = " + searchIDCMB.Text + "";

            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Record Updated");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String query = "";
            employer = employerT.Text;
            position = positionT.Text;
            dateStarted = dateStartedT.Text;
            dateResigned = dateResignedT.Text;
            salary = salaryT.Text;


            query = "UPDATE employment_history SET employer ='" + employer + "'," +
               "position='" + position + "'," +
               "dateStarted='" + dateStarted + "'," +
               "dateResigned='" + dateResigned + "'," +
               "salary ='" + salary + "' " +
               "WHERE emp_id = "+searchIDCMB.Text+"";

            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Record Updated");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "";
            fname = fnameT.Text;
            lname = lnameT.Text;
            mname = mnameT.Text;
            email = emailT.Text;
            phone = phoneT.Text;
            address = addressT.Text;
            age = ageT.Text;
            gender = genderT.Text;
            status = statusT.Text;
            nationality = nationalityT.Text;
            birthday = birthdayT.Value.ToShortDateString();
            birthplace = birthplaceT.Text;

            query = "UPDATE personal_details SET firstname ='"+fname+"'," +
                "middlename='" + mname + "'," +
                "lastname='" + lname + "'," +
                "email='" + email + "'," +
                "phone='" + phone + "'," +
                "address='" + address + "'," +
                "age='" + age + "'," +
                "gender='" + gender + "'," +
                "civilstatus='" + status + "'," +
                "nationality='" + nationality + "'," +
                "birthday='" + birthday + "'," +
                "birthplace ='" + birthplace + "' " +
                "WHERE emp_id = " + searchIDCMB.Text + "";

            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                       
                    }
                }
                else
                {
                    MessageBox.Show("Record Updated");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnameT.Text = "";
            lnameT.Text = "";
            mnameT.Text = "";
            emailT.Text = "";
            phoneT.Text = "";
            addressT.Text = "";
            ageT.Text = "";
            genderT.Text = "";
            statusT.Text = "";
            nationalityT.Text = "";
            birthdayT.Text = "";
            birthplaceT.Text = "";

            employerT.Text = "";
            positionT.Text = "";
            dateStartedT.Text = "";
            dateResignedT.Text = "";
            salaryT.Text = "";

            schoolT.Text = "";
            schoolAddressT.Text = "";
            courseT.Text = "";
            dateCompletedT.Text = "";
        }

        String emp_id;
        private void button2_Click(object sender, EventArgs e)
        {
            String query = "SELECT * from personal_details WHERE emp_id = "+searchIDCMB.Text+" ";
            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        fnameT.Text = myReader.GetString(1);
                        mnameT.Text = myReader.GetString(2);
                        lnameT.Text = myReader.GetString(3);
                        emailT.Text = myReader.GetString(4);
                        phoneT.Text = myReader.GetString(5);
                        addressT.Text = myReader.GetString(6);
                        ageT.Text = myReader.GetString(7);
                        genderT.Text = myReader.GetString(8);
                        statusT.Text = myReader.GetString(9);
                        nationalityT.Text = myReader.GetString(10);
                        birthdayT.Text = myReader.GetString(11);
                        birthplaceT.Text = myReader.GetString(12);
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            String query2 = "SELECT * from employment_history WHERE emp_id = " + searchIDCMB.Text + " ";
            MySqlCommand commandQuery2 = new MySqlCommand(query2, databaseConnection);
            commandQuery2.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery2.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        employerT.Text = myReader.GetString(1);
                        positionT.Text = myReader.GetString(2);
                        dateStartedT.Text = myReader.GetString(3);
                        dateResignedT.Text = myReader.GetString(4);
                        salaryT.Text = myReader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            String query3 = "SELECT * from educational_attainments WHERE emp_id = " + searchIDCMB.Text + " ";
            MySqlCommand commandQuery3 = new MySqlCommand(query3, databaseConnection);
            commandQuery3.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery3.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        schoolT.Text = myReader.GetString(1);
                        schoolAddressT.Text = myReader.GetString(2);
                        courseT.Text = myReader.GetString(3);
                        dateCompletedT.Text = myReader.GetString(4);
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String query = "SELECT emp_id FROM personal_details order by emp_id DESC";
            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        searchIDCMB.Items.Add(myReader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }

        String employer = "", position = "", dateStarted = "", dateResigned = "", salary = "";
        String school = "", schoolAddress = "", dateCompleted = "", course = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String query = "" , query2 = "", query3 = "", query4 = "";
            fname = fnameT.Text;
            lname = lnameT.Text;
            mname = mnameT.Text;
            email = emailT.Text;
            phone = phoneT.Text;
            address = addressT.Text;
            age = ageT.Text;
            gender = genderT.Text;
            status = statusT.Text;
            nationality = nationalityT.Text;
            birthday = birthdayT.Value.ToShortDateString();
            birthplace = birthplaceT.Text;

            MessageBox.Show(fname+"\n"+ mname + "\n" + lname + "\n" + email + 
                "\n" + phone + "\n" + address + "\n" + age + "\n" + 
                gender + "\n" + status + "\n" + nationality + "\n" +fname+"\n"+ birthday + "\n" + birthplace + "\n" );
           
            
            query = "INSERT INTO personal_details (firstname,middlename,lastname,email,phone,address,age,gender,civilstatus,nationality,birthday,birthplace)" +
                "VALUES('"+fname+ "','" + mname + "','" + lname + "','" + email + "','" + phone + "','" + address + "','" + age + "','" + gender + "','" + status + "'," +
                "'" + nationality + "','" + birthday + "','" + birthplace + "')	";

            String MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employee_masterlist";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandQuery = new MySqlCommand(query, databaseConnection);
            commandQuery.CommandTimeout = 60;


            query2 = "SELECT emp_id FROM personal_details order by emp_id DESC LIMIT 1";

            // save personal_details 
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Console.WriteLine(myReader.GetString(1));
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
            // get generated ID 
            String id = "";

            MySqlCommand commandQuery2 = new MySqlCommand(query2, databaseConnection);
            commandQuery2.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery2.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        id = myReader.GetString(0);
                        MessageBox.Show("id : "+  id);
                    }
                }
                else
                {
                    MessageBox.Show("Record Saved");
                }
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            employer = employerT.Text;
            position = positionT.Text;
            dateStarted = dateStartedT.Text;
            dateResigned = dateResignedT.Text;
            salary = salaryT.Text;

            query3 = "INSERT INTO employment_history (emp_id,employer,position,dateStarted,dateResigned,salary)" +
                "VALUES('" + id + "','" + employer + "','" + position + "','" + dateStarted + "','" + dateResigned + "','" + salary + "')	";

            MySqlCommand commandQuery3 = new MySqlCommand(query3, databaseConnection);
            commandQuery3.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery3.ExecuteReader();
     
               MessageBox.Show("Record Saved");
            
                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }

            school = schoolT.Text;
            schoolAddress = schoolAddressT.Text;
            course = courseT.Text;
            dateCompleted = dateCompletedT.Text;

            query4 = "INSERT INTO educational_attainments (emp_id,school,schoolAddress,course,dateCompleted)" +
                "VALUES('" + id + "','" + school + "','" + schoolAddress + "','" + course + "','" + dateCompleted + "')	";
            MySqlCommand commandQuery4 = new MySqlCommand(query4, databaseConnection);
            commandQuery4.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandQuery4.ExecuteReader();

                MessageBox.Show("Record Saved");

                databaseConnection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "");
            }
        }
    }
}
