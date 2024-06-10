using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Assignment_5_Zain_Ashraf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        DataTable dataTable;


        void Student_Show()
        {
            //Connection String 
             //conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\ZainAshraf_DB.accdb");

            // Connecttion String only for my laptop as this location is located in my Laptop only.
            // conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\!Google Drive Data 2259\\!Today\\Assignment_6_Zain_Ashraf\\Assets\\ZainAshraf_DB.accdb\"");

            // Connection String for User who will install it using Setup File.
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Zain_Custom_DB_Application\\ZainAshraf_DB.accdb\"");

            // string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \"C:\\Program Files\\Default Company Name\\Programming_Champs_POS\\POS_DB.accdb\"";

            dataTable = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM students_data", conn);
            conn.Open();
            adapter.Fill(dataTable);
            MyGridView.DataSource = dataTable;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student_Show();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            // Validation //

            // Name TextBox Validation
            if (string.IsNullOrWhiteSpace(Name_Textbox.Text))
            {
                MessageBox.Show("Please Enter Your NAME to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // City TextBox Validation
            if (string.IsNullOrWhiteSpace(City_Textbox.Text))
            {
                MessageBox.Show("Please Enter Your CITY to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Title TextBox Validation
            if (string.IsNullOrWhiteSpace(Title_Textbox.Text))
            {
                MessageBox.Show("Please Enter Your TITLE to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Country TextBox Validation
            if (string.IsNullOrWhiteSpace(Country_Textbox.Text))
            {
                MessageBox.Show("Please Enter Your COUNTRY to Proceed Next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO students_data (Student_Name, City, Title, Date_of_Birth, Country)" +
                "VALUES (@name, @city, @title, @dob, @country)";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", Name_Textbox.Text);
            cmd.Parameters.AddWithValue("@city", City_Textbox.Text);
            cmd.Parameters.AddWithValue("@title", Title_Textbox.Text);
            cmd.Parameters.AddWithValue("@dob", Date_Time_Picker);
            cmd.Parameters.AddWithValue("@country", Country_Textbox.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Congratulations! All the Data is Submitted in DataBase Successfully.", "Data Inserted Successfully", MessageBoxButtons.OK);

            Student_Show();
        }

        private void Grid_Cell_Focus(object sender, DataGridViewCellEventArgs e)
        {
            ID_TextBox.Text = MyGridView.CurrentRow.Cells[0].Value.ToString();
            Name_Textbox.Text = MyGridView.CurrentRow.Cells[1].Value.ToString();
            City_Textbox.Text = MyGridView.CurrentRow.Cells[2].Value.ToString();
            Title_Textbox.Text = MyGridView.CurrentRow.Cells[3].Value.ToString();
            Date_Time_Picker.Text = MyGridView.CurrentRow.Cells[4].Value.ToString();
            Country_Textbox.Text = MyGridView.CurrentRow.Cells[5].Value.ToString();
        }

        /*
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM students_data WHERE Id = @id";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_TextBox.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Clone();

            MessageBox.Show("The Selected Record is Deleted Successfully!","Deleted Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Student_Show();
        }
        */

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            // Display a Confirmation Dialog
            DialogResult result = MessageBox.Show("Are you sure you want to Delete the Selected Record?", "Confirm Deletion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If Yes
            if (result == DialogResult.Yes)
            {
                // Deletion Code
                string query = "DELETE FROM students_data WHERE Id = @id";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_TextBox.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("The Selected Record is Deleted Successfully!", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Student_Show();
            }

            // If No
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
        private void Update_Button_Click(object sender, EventArgs e)
        {
            string query = " UPDATE students_data " +
                 "SET Student_Name=@name,City=@city,Title=@title,Date_of_Birth=@dob,Country=@country " +
                 "WHERE Id=@id";


            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", Name_Textbox.Text);
            cmd.Parameters.AddWithValue("@city", City_Textbox.Text);
            cmd.Parameters.AddWithValue("@title", Title_Textbox.Text);
            cmd.Parameters.AddWithValue("@dob", Date_Time_Picker);
            cmd.Parameters.AddWithValue("@country", Country_Textbox.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_TextBox.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Selected Record Data is Updated Successfully","Updated Successfully", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Student_Show();
        }

        private DataTable originalDataSource;

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string searchText = Search_Textbox.Text.ToLower();

            // Filter the data source based on the search criteria
            DataTable filteredData = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                bool rowVisible = false;

                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(searchText))
                    {
                        rowVisible = true;
                        break;
                    }
                }

                if (rowVisible)
                {
                    filteredData.ImportRow(row); // Add matching rows to the filtered data table
                }
            }

            // Bind the filtered data to the DataGridView
            MyGridView.DataSource = filteredData;

            Search_Textbox.Text = "";
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            // Restore the original data source to the DataGridView
            MyGridView.DataSource = originalDataSource;
        }

    }
}
