using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;         //Connect Microsoft Access Database
namespace Forensics_Software_Usage
{
    public partial class Menu : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Menu()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bbesinaiz\Documents\04 NSU\02 Spring 2018\CSC 494\Final Project\SoftwareUsage.accdb;
Persist Security Info=False;";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                //Hides Form 1/ Login screen
            Network f3 = new Network();     //Create form2 object
            f3.ShowDialog();            //Opens Form 2
        }

        private void Computer_Click(object sender, EventArgs e)
        {
            //this.Hide();                //Hides Form 1/ Login screen
            Computer f2 = new Computer();     //Create form2 object
            f2.ShowDialog();            //Opens Form 2
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      //Opens database
                //Logic to perform
                //checkConnection.Text = "Connection Success";

                connection.Close();     //Closes Database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            this.Hide();                        //Hides Menu Form
            Memory f4 = new Memory();           //Create Memory object
            f4.ShowDialog();                    //Opens Memory Form
        }

        private void Mobile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile f5 = new Mobile();
            f5.ShowDialog();
        }

        private void Digital_Click(object sender, EventArgs e)
        {
            this.Hide();
            Steganography f6 = new Steganography();
            f6.ShowDialog();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multi f7 = new Multi();
            f7.ShowDialog();
        }

        private void Miscellenous_Click(object sender, EventArgs e)
        {
            this.Hide();
            Miscellaneous f8 = new Miscellaneous();
            f8.ShowDialog();
        }
    }
}
