using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                textBox1.ForeColor = Color.White;
                panel5.Visible = false;
            }
            catch
            { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    return;
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel7.Visible = false;
            }
            catch
            { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void button1_DragLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "Password")
                {
                panel7.Visible = true;
                textBox2.Focus();
                return;
            }
            Main  f = new Main();
            f.Show();
            this.Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.Green;
           
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(30, 30, 30);
            button3.ForeColor = Color.Lime;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Username")
            {
                pnlUsername.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
            if (textBox4.Text == "Enter Contact")
            {
                pnlContact.Visible = true;
                textBox4.Focus();
                textBox4.SelectAll();
                return;
            }
            if (textBox5.Text == "Enter Password")
            {
                pnlPassword.Visible = true;
                textBox5.Focus();
                textBox5.SelectAll();
                return;
            }
            if (textBox6.Text == "Enter Confirm Password")
            {
                pnlCPassword.Visible = true;
                textBox6.Focus();
                textBox6.SelectAll();
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlUsername.Visible = pnlContact.Visible = pnlPassword.Visible = pnlCPassword.Visible = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.Green;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Dock=DockStyle.Fill;
            pnlsign.Visible = false;
            pnlLogo.Dock = DockStyle.Left;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            pnlsign.Visible = true;
            pnlsign.Dock = DockStyle.Fill;
            
            pnlLogo.Dock = DockStyle.Right;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "Enter Username")
            {
                pnlUsername.Visible = true;
                textBox10.Focus();
                textBox10.SelectAll();
                return;
            }
            if (textBox9.Text == "Enter Contact")
            {
                pnlContact.Visible = true;
                textBox9.Focus();
                textBox9.SelectAll();
                return;
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
            button4.BackColor = Color.Green;
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;
            pnlForgotPassword.Visible = false;
            pnlLogo.Dock = DockStyle.Left;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            pnlForgotPassword.Visible = true;
            pnlForgotPassword.Dock = DockStyle.Fill;
            
            pnlLogo.Dock = DockStyle.Right;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

