using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class insurenceForm : Form
    {


        public insurenceForm()
        {
            InitializeComponent();
        }
        public ArrayList searchPeriod(decimal startPeriod, decimal endPeriod)
        {
            ArrayList arrayList = new ArrayList();
            while (startPeriod < endPeriod)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                var formatedStartPeriod = Convert.ToDecimal(startPeriod, new CultureInfo("en-US"));
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT finished FROM blood_services WHERE finished > {formatedStartPeriod} GROUP BY finished ORDER BY MIN(finished)";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                Int64 newPeriod = (from DataRow dr in table.Rows
                                   select (Int64)dr["finished"]).FirstOrDefault();

                if(newPeriod==0)
                { return arrayList; }
                arrayList.Add(newPeriod);
                startPeriod = (newPeriod);
            }
            return arrayList;
        }

        public ArrayList searchBlood(ArrayList time)
        {
            ArrayList bloodList = new ArrayList();
            for(int i = 0; i < time.Count;i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT blood FROM blood_services WHERE finished = {time[i]} ";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int blood = (from DataRow dr in table.Rows
                                   select (int)dr["blood"]).First();

                bloodList.Add(blood);
            }
            return bloodList;
        }
        public ArrayList searchPatient(ArrayList bloodList)
        {
            ArrayList patientList = new ArrayList();
            for (int i = 0; i < bloodList.Count; i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT patient FROM blood WHERE id = {bloodList[i]} ";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int patient = (from DataRow dr in table.Rows
                             select (int)dr["patient"]).First();

                patientList.Add(patient);
            }
            return patientList;
        }
        public int searchInsuranceId(string insuranceName)
        {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT id FROM insurance WHERE name = '{insuranceName}' ";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int id = (from DataRow dr in table.Rows
                     select (int)dr["id"]).First();
            return id;
        }
        public ArrayList searchFullname(ArrayList patientsId, int insuranceId)
        {
            ArrayList fullnameList = new ArrayList();
            for (int i = 0; i < patientsId.Count; i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT fullname FROM patients WHERE id = {patientsId[i]} and insurance = {insuranceId} ";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count != 0)
                {
                    string fullname = (from DataRow dr in table.Rows
                                       select (string)dr["fullname"]).First();
                    fullnameList.Add(fullname);
                }
            }
            return fullnameList;
        }
        ArrayList datesList = new ArrayList();
        private void btnReportPost_Click(object sender, EventArgs e)
        {
            DateTimeOffset dateStart = fromPaymentCalendar.SelectionRange.Start;
            decimal unixTimeStart = dateStart.ToUnixTimeMilliseconds();
            DateTimeOffset dateEnd = toPaymentCalendar.SelectionRange.Start;
            decimal unixTimeEnd = dateEnd.ToUnixTimeMilliseconds();
            if (unixTimeStart > unixTimeEnd)
            {
                MessageBox.Show("Дата конца больше даты начала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datesList = searchPeriod(unixTimeStart, unixTimeEnd);
                ArrayList blood = searchBlood(datesList);
                int insuranceId = searchInsuranceId(insuranceBox.Text);
                ArrayList patientsIds = searchPatient(blood);
                ArrayList patientsFullname = searchFullname(patientsIds,insuranceId);

                ArrayList costService = new ArrayList();
                
                decimal totalcost = 0;
            }
        }

        private void insurenceForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = "SELECT name FROM insurance";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                insuranceBox.Items.Add((string)reader["name"]);
            }
        }
    }
}
