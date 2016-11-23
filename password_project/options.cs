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
namespace password_project
{
    public partial class options : Form
    {
        Bussines_layer.encrption en = new Bussines_layer.encrption();

        Bussines_layer.options op = new Bussines_layer.options();
        public options()
        {
            InitializeComponent();
            dataGridView1.DataSource = op.all_account();
            dataGridView1.Columns[1].Visible=false;

        }
        
      
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (account_name.Text != string.Empty && web_address.Text != string.Empty && passTXT.Text != string.Empty)
                {
                    op.insert_account(en.EncodeHex(account_name.Text), en.EncodeHex(web_address.Text), en.EncodeHex(usernameTXT.Text), en.EncodeHex(passTXT.Text), en.EncodeHex(desctxt.Text));
                    MessageBox.Show("the Account added succssful");
                    dataGridView1.DataSource = op.all_account();
                    dataGridView1.Columns[1].Visible = false;
                    web_address.Clear();
                    usernameTXT.Clear();
                    passTXT.Clear();
                    account_name.Clear();
                    desctxt.Clear();

                
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passTXT.PasswordChar = (char)0;

            }
            else
                passTXT.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Do you want to delete current Account ?", "Delete Account ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                op.Delete_account(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
                dataGridView1.DataSource = op.all_account();
                dataGridView1.Columns[1].Visible = false;
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            web_address.Text=en.DecodeHex(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            usernameTXT.Text = en.DecodeHex(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            passTXT.Text = en.DecodeHex(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            account_name.Text = en.DecodeHex(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            desctxt.Text = en.DecodeHex(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (account_name.Text != string.Empty && web_address.Text != string.Empty && passTXT.Text != string.Empty)
                {
                    op.Edite_Account(account_name.Text, web_address.Text, web_address.Text, passTXT.Text, desctxt.Text,Convert.ToInt32( dataGridView1.CurrentRow.Cells[1].Value));
                    MessageBox.Show("the Account updated succssful");
                    dataGridView1.DataSource = op.all_account();
                    dataGridView1.Columns[1].Visible = false;
                    web_address.Clear();
                    usernameTXT.Clear();
                    passTXT.Clear();
                    account_name.Clear();
                    desctxt.Clear();


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

        private void options_Load(object sender, EventArgs e)
        {

        }
    }
}
