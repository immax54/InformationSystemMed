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
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{

    public partial class getMaterial : Form
    {
        loginForm loginForm;
        public getMaterial(loginForm login)
        {
            InitializeComponent();
            this.loginForm = login;
        }

        int valueBlood;
        string barcode;
        private void getMaterial_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT id FROM blood GROUP BY id ORDER BY MAX(id) DESC";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int blood = (from DataRow dr in table.Rows
                         select (int)dr["id"]).FirstOrDefault();
            string number = blood.ToString();
            valueBlood = Int32.Parse(number)+1;
            codeBox.Text=valueBlood.ToString();
            codeBox.ForeColor = Color.Black;

            sqlQuerry = "SELECT fullname FROM patients";
            connect = new SqlConnection(conn);
            connect.Open();
            command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                patientBox.Items.Add((string)reader["fullname"]);
            }
            sqlQuerry = "SELECT Service from services";
            connect = new SqlConnection(conn);  
            connect.Open();
            command = new SqlCommand (sqlQuerry, connect);
            adapter.SelectCommand = command;    
            adapter.Fill(table);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                serviceBox.Items.Add((string)reader["Service"]);
            }
            sqlQuerry = "SELECT Service from services";
            connect = new SqlConnection(conn);
            connect.Open();
            command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                serviceBoxlist.Items.Add((string)reader["Service"]);
            }
        }
        String sDate;
        private void codeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT id FROM blood WHERE id = '{codeBox.Text}'";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                string endValue = "";
                if (table.Rows.Count ==0)
                {
                    valueBlood = Int32.Parse(codeBox.Text);

                    while (endValue=="")
                    { 
                     sDate = DateTime.Now.ToString();
                    DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
                    String dy = datevalue.Day.ToString();
                    String mn = datevalue.Month.ToString();
                    String yy = datevalue.Year.ToString();
                    Random rnd = new Random();
                    int firstValue = rnd.Next(1, 10);
                    int value = rnd.Next(114562, 999999);
                    endValue = firstValue+dy+mn+yy+value.ToString();
                    barcode = firstValue+value.ToString();
                    conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                    sqlQuerry = $"SELECT barcode FROM blood WHERE barcode = '{endValue}'";
                    connect = new SqlConnection(conn);
                    connect.Open();
                    command = new SqlCommand(sqlQuerry, connect);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if(table.Rows.Count!=0)
                        {
                            endValue="";
                        }
                    }
                    label2.Text = $"Штрих код пробирки:{endValue}";
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XFont font = new XFont("Verdana", 25, XFontStyle.Bold);
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawString(endValue, font, XBrushes.Black,
                    new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                    string filename = "Barcode.pdf";
                    document.Save(filename);
                    patientBox.Visible = true;
                    nameLabel.Visible = true;
                    serviceBox.Visible = true;
                    serviceLabel.Visible = true;
                    createButton.Visible = true;
                    completeButton.Visible = true;
                    codeBox.Enabled = false;
                    btnGetMaterial.Enabled = false;
                    serviceBoxlist.Visible = true;
                    serviceListLabel.Visible = true;
                    downloadPdfBtn.Visible = true;
                    showPatients.Visible = true;
                }
                else
                {
                  MessageBox.Show("Ошибка", "Существующий код пробирки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGetMaterial_Click(object sender, EventArgs e)
        {
            sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
            Random rnd = new Random();
            int firstValue = rnd.Next(1, 10);
            int value = rnd.Next(114562, 999999);
            string endValue = firstValue+dy+mn+yy+value.ToString();
            barcode = firstValue+value.ToString();
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XFont font = new XFont("Verdana", 25, XFontStyle.Bold);
            XGraphics gfx = XGraphics.FromPdfPage(page);
            gfx.DrawString(endValue, font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            string filename = "Barcode.pdf";
            document.Save(filename);
            label2.Text = $"Считанный штрих код пробирки:{endValue}/r";
            codeBox.Text = endValue;
            patientBox.Visible = true;
            nameLabel.Visible = true;
            serviceBox.Visible = true;
            serviceLabel.Visible = true;
            createButton.Visible = true;
            completeButton.Visible = true;
            codeBox.Enabled = false;
            btnGetMaterial.Enabled = false;
            serviceBoxlist.Visible = true;
            serviceListLabel.Visible = true;
            downloadPdfBtn.Visible = true;
            showPatients.Visible = true;
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            string patient, service;
            if (patientBox.SelectedItem==null||serviceBox.SelectedItem==null)
            {
                MessageBox.Show("Ошибка при выборе пользователя или услуги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                patient = patientBox.SelectedItem.ToString();
                service= serviceBox.SelectedItem.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT id FROM patients WHERE fullname = '{patient}'";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int patientID = (from DataRow dr in table.Rows
                            select (int)dr["id"]).First();
                sqlQuerry = $"SELECT Code FROM DB.dbo.services WHERE Service = '{service}'";
                connect.Open();
                command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int serviceID = (from DataRow dr in table.Rows
                                 select (int)dr["id"]).FirstOrDefault();
                
                Int32 unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                sqlQuerry = $"INSERT INTO blood(id,patient,barcode,date,deleted) VALUES(${valueBlood},${patientID},${barcode},${unixTimestamp}000,0)";
                command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                this.Hide();
                loginForm loginForm = new loginForm();
                loginForm.ShowDialog();
            }
        }
        
        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            createPatient create = new createPatient();
            create.ShowDialog();

        }
        public int searchPatient(string patient)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT id FROM patients WHERE fullname = '{patient}'";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int patientID = (from DataRow dr in table.Rows
                             select (int)dr["id"]).First();
            return patientID;
        }
        private void getMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            formReserch formReserch = new formReserch(this.loginForm);
            formReserch.ShowDialog();
            this.Hide();
        }
        public DateTime unixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixtime).ToLocalTime();
            return dtDateTime;
        }


        public Int64 searchSocNum(string patientSearch)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry= $"SELECT social_sec_number FROM patients WHERE fullname = '{patientSearch}'";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Int64 searched = (from DataRow dr in table.Rows
                           select (Int64)dr["social_sec_number"]).FirstOrDefault();
            return searched;
        }


        public DateTime searchBirth(string patientSearch)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT birthdate_timestamp FROM patients WHERE fullname = '{patientSearch}'";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Int64 birthDay = (from DataRow dr in table.Rows
                            select (Int64)dr["birthdate_timestamp"]).FirstOrDefault();
            birthDay= birthDay/1000;
            DateTime birthDayNormal = unixTimeToDateTime(birthDay);
            return birthDayNormal;
        }

        public void orderPlace(string services, Single cost, int patient)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"insert into orderService(services,patient,cost) values ('{services}',{patient},{Math.Round(cost)})";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public Single searchServices(ArrayList array)
        {
            Single cost = 0;
            for (int i = 0; i < array.Count; i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
                string sqlQuerry = $"SELECT Price FROM services WHERE Service = '{array[i]}'";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                Single costForOne = (from DataRow dr in table.Rows
                                  select (Single)dr["Price"]).FirstOrDefault();
                cost +=  costForOne;
            }
            return cost;
        }

        ArrayList arrayList = new ArrayList();
        private void downloadPdfBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT id FROM orderService GROUP BY id ORDER BY MAX(id) DESC";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int idOrder = (from DataRow dr in table.Rows
                         select (int)dr["id"]).FirstOrDefault();
            int idOrderInc = idOrder+1;
            string patientSearch = patientBox.Text;

            Int64 socialNum = searchSocNum(patientSearch);

            DateTime birthDayNormal = searchBirth(patientSearch);

            
            foreach (object item in serviceBoxlist.CheckedItems)
            {
                arrayList.Add(item);
            }

            Single totalCost = searchServices(arrayList);

            string services= "";
            for (int i = 0; i < serviceBoxlist.Items.Count; i++)
            {
                if (serviceBoxlist.GetItemChecked(i))
                {
                    string str = (string)serviceBoxlist.Items[i];
                    services += $"{str},";
                }
            }

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XFont font = new XFont("Verdana", 5, XFontStyle.Bold);
            XGraphics gfx = XGraphics.FromPdfPage(page);
            gfx.DrawString($"Дата заказа| Номер заказа| Номер пробирки| Номер страхового полиса| ФИО| Дата рождения| Перечень услуг| Стоимость", font, XBrushes.Black,
                    new XRect(0, -10, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString($"{sDate}|{idOrderInc}|{valueBlood}|{socialNum}|{patientBox.Text}|{birthDayNormal}|{services}|{totalCost}", font, XBrushes.Black,
                    new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            string filename = "orderPayment.pdf";
            document.Save(filename);
            orderPlace(services, totalCost, searchPatient(patientBox.Text));
            MessageBox.Show("Запись сохранена и выгружена в PDF","Загрузка",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPatients_Click(object sender, EventArgs e)
        {
            searchPatients search = new searchPatients();
            this.Hide();
            search.Show();
        }

        private void patientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            downloadPdfBtn.Enabled = true;
        }
    }
}
