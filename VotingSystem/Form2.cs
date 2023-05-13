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

namespace VotingSystem
{
    public partial class Form2 : Form
    {
        FRM_Login f1 = new FRM_Login();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();

            //birth date
            for (int i = 1; i<32; i++) 
            { 
                Date.Items.Add(i);
            }

            //birth year
            for (int j = 1990; j<2024; j++) 
            {
                Year.Items.Add(j);
            }

            //College year
            for (int k = 1; k < 3; k++)
            {
                Year.Items.Add(k);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Register VALUES('"+txtb_Firstname.Text+"','"+txtb_Lastname.Text+"', '"+txtb_MiddleName.Text+"', '"+Course.SelectedItem.ToString()+"', " +
           "'" + Cyear.SelectedItem.ToString() + "','" + Age.Text + "','" + txtb_IDnumber.Text + "','" + txtb_Password.Text + "'," +
           "'" + Date.SelectedItem.ToString() + "','" + Month.SelectedItem.ToString() + "','" + Year.SelectedItem.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Create Account Successfull!");

           

            Hide();
            f1.Show();


        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            Hide();
            f1.ShowDialog();
        }
    }
}
