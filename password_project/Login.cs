using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_project
{
    public partial class Login : Form
    {
        Bussines_layer.Login log = new Bussines_layer.Login();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = log.login(usernameTXT.Text, passTXT.Text);
            if (usernameTXT.Text == string.Empty ||passTXT.Text == string.Empty)
            {
                MessageBox.Show("username or password is empty","complete information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (dt.Rows.Count> 0)
            {
                MessageBox.Show("LOgin success");
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.ShowDialog();
            }
            else
            {
                MessageBox.Show("password or username is incorrect","LOGIN failure",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = log.login(usernameTXT.Text, passTXT.Text);
            if (usernameTXT.Text == string.Empty || passTXT.Text == string.Empty)
            {
                MessageBox.Show("username or password is empty", "complete information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("LOgin success");
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.ShowDialog();
            }
            else
            {
                MessageBox.Show("password or username is incorrect", "LOGIN failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passTXT.PasswordChar = (char)0;

            }
            else
                passTXT.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
