using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using System.Data.SqlClient;
using System.Diagnostics;
namespace password_project
{
    public partial class MainMenu : Form
    {
        Bussines_layer.encrption en = new Bussines_layer.encrption();

        Bussines_layer.options op = new Bussines_layer.options();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (account_name.Text != string.Empty && usernameTXT.Text != string.Empty && passTXT.Text != string.Empty)
                {
                    op.insert_account(en.EncodeHex(account_name.Text), en.EncodeHex(web_address.Text), en.EncodeHex(usernameTXT.Text), en.EncodeHex(passTXT.Text), en.EncodeHex(desctxt.Text));
                    MessageBox.Show("the Account added succssful");
                }
                else
                {
                    MessageBox.Show("you should input value in account_name ,username ,password fields", "complete information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            options op = new options();
            op.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("You want to Exit?", "close program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    Application.Exit();
            

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(web_address.Text);

        }
    }
}
