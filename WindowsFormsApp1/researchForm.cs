using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formReserch : Form
    {
        loginForm loginForm;
        public formReserch(loginForm login)
        {
            InitializeComponent();
            this.loginForm = login;
        }

        private void btnGetMaterial_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           getMaterial getMaterial = new getMaterial(this.loginForm);
            this.Hide();
            getMaterial.ShowDialog();
        }

        private void formReserch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm(); 
            login.ShowDialog();
        }
        public DateTime startTime = DateTime.Now;
        string nameLab;
        private void formReserch_Load(object sender, EventArgs e)
        { 
            if (nameLab ==null)
            {
                nameLab = loginForm.nameLabel.Text;
            }
            usernameLabel.Text = nameLab;
            timerLabel.Text = TimeSpan.FromMinutes(30).ToString();
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = (TimeSpan.FromMinutes(30) - (DateTime.Now - startTime)).ToString();

        }
    }
}
