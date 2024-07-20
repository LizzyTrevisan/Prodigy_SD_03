using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;


namespace Prodigy_SD_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void LoadDataGridView() //to clean the textbox once an information is inserted, updated or deleted.
        {
            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private DataRow? GetExistingRecord(int id)//insert, update or delete a specific information without having to fill all the boxes in
        {
            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    MessageBox.Show("No record found with the specified ID.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return null;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Validate ID input
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid integer for ID.");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into [Table] (ID, Name, Phone, Email) values (@ID, @Name, @Phone, @Email)", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Saved");
                ClearTextBoxes();
                LoadDataGridView(); // it refreshes the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate ID input
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid integer for ID.");
                return;
            }

            DataRow? existingRecord = GetExistingRecord(id);
            if (existingRecord == null) return;

            // used to support the call function GetExistingRecord
            string name = !string.IsNullOrWhiteSpace(textBox2.Text) ? textBox2.Text : (existingRecord["Name"]?.ToString() ?? string.Empty);
            string phone = !string.IsNullOrWhiteSpace(textBox3.Text) ? textBox3.Text : (existingRecord["Phone"]?.ToString() ?? string.Empty);
            string email = !string.IsNullOrWhiteSpace(textBox4.Text) ? textBox4.Text : (existingRecord["Email"]?.ToString() ?? string.Empty);

            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [Table] SET Name=@Name, Phone=@Phone, Email=@Email WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated");
                ClearTextBoxes();
                LoadDataGridView(); // it refreshes the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Validate ID input
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid integer for ID.");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Deleted");
                ClearTextBoxes();
                LoadDataGridView(); // it refreshes the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Validate ID input
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid integer for ID.");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)//createt for the user to be able to download the table as EXcel File
        {
            SqlConnection con = new SqlConnection("Data Source=LEIZIANE\\SQLEXPRESS;Initial Catalog=AppTable;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    FileName = "contacts.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(dt, "Contacts");
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("File successfully saved.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}