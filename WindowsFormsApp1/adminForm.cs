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

namespace WindowsFormsApp1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        private DataTable table;
        private void searchButton_Click(object sender, EventArgs e)
        {
            usersBindingSource1.EndEdit();
            usersTableAdapter.Update(dBDataSet1);
            bloodBindingSource.EndEdit();
            bloodTableAdapter.Update(dBDataSet1);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"select * from patients";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.adminGridView.DataSource= table;
            adminGridView.DataSource = table;
            connect.Close();

        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            bloodBindingSource.EndEdit();
            bloodTableAdapter.Update(dBDataSet1);
            patientsBindingSource.EndEdit();
            patientsTableAdapter.Update(dBDataSet1);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"select * from users";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.adminGridView.DataSource= table;
            adminGridView.DataSource = table;
            connect.Close();
        }

        private void blood_serviceButton_Click(object sender, EventArgs e)
        {
            usersBindingSource1.EndEdit();
            usersTableAdapter.Update(dBDataSet1);
            patientsBindingSource.EndEdit();
            patientsTableAdapter.Update(dBDataSet1);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"select * from blood_services";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.adminGridView.DataSource= table;
            adminGridView.DataSource = table;
            connect.Close();
        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.ShowDialog();
        }
    }
}
