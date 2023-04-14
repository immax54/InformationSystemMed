using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class searchPatients : Form
    {
        public searchPatients()
        {
            InitializeComponent();
        }
        loginForm loginForm;
        private void searchPatients_Load(object sender, EventArgs e)
        {
          this.patientsTableAdapter.Fill(this.dBDataSet.patients);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"select * from patients where fullname like '%{fullnameSearchBox.Text}%' and guid like '%{guidSearchBox.Text}%' and social_sec_number like '%{socialNumberSearchBox.Text}%' and ein like '%{einSearchBox.Text}%' and passport_n like '%{passport_nSearchBox.Text}%' and passport_s like '%{passport_sSearchBox.Text}%'";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void searchPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            patientsBindingSource.EndEdit();
            patientsTableAdapter.Update(dBDataSet);
            getMaterial get = new getMaterial(this.loginForm);
            get.ShowDialog();
            this.Hide();
        }
    }
}
