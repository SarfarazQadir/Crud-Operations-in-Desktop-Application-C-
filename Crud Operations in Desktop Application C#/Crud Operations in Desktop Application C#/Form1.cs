using System.Data.SqlClient;

namespace Crud_Operations_in_Desktop_Application_C_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;User=sa;Password=123456789;Database=CRUD_Operations_in_Windows");
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string query = "Insert into Values ('" + id.Text + "','" + name.Text + "','" + age.Text + "','" + email.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            conn.Open();
            cmd.BeginExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully");
        }
    }
}
