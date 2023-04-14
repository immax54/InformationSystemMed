using PdfSharp.Drawing;
using PdfSharp.Drawing.BarCodes;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class createPatient : Form
    {
        public createPatient()
        {
            InitializeComponent();
        }
        loginForm loginForm;
        private void createPatient_Load(object sender, EventArgs e)
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
                companyBox.Items.Add((string)reader["name"]);
            }


            typecbBox.Items.Add("oms");
            typecbBox.Items.Add("dms");
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TextChangedLetter(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(fullnameBox.Text, "^[a-zA-Z ]"))
            {
                fullnameBox.Text.Remove(fullnameBox.Text.Length - 1);
            }
        }
        private static Random random = new Random();
        public static string randomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT id FROM patients GROUP BY id ORDER BY MAX(id) DESC";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int MaxId = (from DataRow dr in table.Rows
                             select (int)dr["id"]).FirstOrDefault();
                string Id = MaxId.ToString();
                int IdPatient = Int32.Parse(Id)+1;

                DateTimeOffset date = birthCalendar.SelectionRange.Start;
                string unixTime = date.ToUnixTimeMilliseconds().ToString();
                string fullName = fullnameBox.Text;
                string passportNumSerial = passportNumBox.Text;
                string passportSecNum = passportNumberBox.Text;
                string telephone = telphoneBox.Text;
                string email = emailBox.Text;
                string cbnumb = cbnumberBox.Text;
                string typecb = typecbBox.Text;
                string companyName = companyBox.Text;
                string login = randomString(9);
                string password = randomString(8);
                string uid = $"{randomString(8)}-{randomString(4)}-{randomString(4)}-{randomString(4)}-{randomString(12)}";
                Random rnd = new Random();
                int firstValue = rnd.Next(10, 80);
                int secValue = rnd.Next(1000000,9000000);
                string finalSTR = $"{firstValue}-{secValue}";
                if (fullName==""||passportNumSerial==""||passportSecNum==""||telephone=="+"||email==""||cbnumb==""||typecb==""||companyName=="")
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sqlQuerry = $"insert into patients (fullname,login,pwd,guid,email,social_sec_number,ein,social_type,phone,passport_s,passport_n,birthdate_timestamp,id,country,ipadress,ua,deleted) values ('{fullName}','{login}','{password}','{uid}','{email}','{cbnumb}','{finalSTR}','{typecb}','{telephone}','{passportNumSerial}','{passportSecNum}','{unixTime}','{IdPatient}',NULL,NULL,NULL,0)";
                    command = new SqlCommand(sqlQuerry, connect);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Пациент добавлен", "Добавление", MessageBoxButtons.OK);
                    this.Close();
                    getMaterial get = new getMaterial(this.loginForm);
                    get.Show();
                }
            }
        }

        private void createPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            getMaterial get = new getMaterial(this.loginForm);
            get.Show();
            this.Hide();
        }

    }
}
