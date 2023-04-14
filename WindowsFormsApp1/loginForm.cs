using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public string findUser(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT name FROM users WHERE login = '{login}'";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string username = (from DataRow dr in table.Rows
                        select (string)dr["name"]).FirstOrDefault();
            return username;
        }
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
            var password = passwordBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string conn = "Data Source=localhost;Initial Catalog=DB;Integrated Security=True";
            string sqlQuerry = $"SELECT login,password,type FROM users WHERE login = '{login}' and password = '{password}' ";
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand command = new SqlCommand(sqlQuerry, connect);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int type = (from DataRow dr in table.Rows
                      select (int)dr["type"]).FirstOrDefault();
             string Fullusername = findUser(login);
            if (captchaBox.Text == "R6W5" || captchaBox.Text ==  "r6w5" || captchaBox.Text ==  "R6w5")
            {
            if(table.Rows.Count == 1)
            {
                    nameLabel.Text = Fullusername;
                    if (type == 1)
                    {
                        MessageBox.Show("Вход выполнен", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formReserch formReserch = new formReserch(this);
                        this.Hide();
                        formReserch.ShowDialog();
                        
                    }
                    if (type == 2)
                    {
                        MessageBox.Show("Вход выполнен", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        assistlabForm assistlabFormNew = new assistlabForm();
                        this.Hide();
                        assistlabFormNew.ShowDialog();
                    }
                    if (type == 3)
                    {
                        MessageBox.Show("Вход выполнен", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insurenceForm insurenceForms = new insurenceForm();
                        this.Hide();
                        insurenceForms.ShowDialog();
                    }
                    if (type == 4)
                    {
                        MessageBox.Show("Вход выполнен", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adminForm adminForms = new adminForm();
                        this.Hide();
                        adminForms.ShowDialog();
                    }
                }
            else
            {
                MessageBox.Show("Не верный пароль или логин", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
            }
            }
            else
            {
                MessageBox.Show("Не верная капча", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
            }
        }


        int flag = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"C:\Users\immaks54\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\captcha1.png");
            Bitmap bmp3 = new Bitmap(@"C:\Users\immaks54\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\captcha3.png");
            flag *= -1;
            if (flag==-1)
            {
                captcha.Image= bmp;
            }
            else
            {
                captcha.Image= bmp3;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar= true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
