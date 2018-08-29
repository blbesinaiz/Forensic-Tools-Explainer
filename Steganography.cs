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
    public partial class Steganography : Form
    {
        private OleDbConnection connection = new OleDbConnection();     //Only form 1 can use connection - GLOBAL VARIABLE
        public Steganography()
        {
            InitializeComponent();
            //Declare oledb connection object
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bbesinaiz\Documents\04 NSU\02 Spring 2018\CSC 494\Final Project\SoftwareUsage.accdb;
Persist Security Info=False;";
        }

        private void Digital_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      //Opens database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Steganography";
                //MessageBox.Show(query)
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combo_Tools.Items.Add(reader["Tool"].ToString()); //Add values from database
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void but_menu_Click(object sender, EventArgs e)
        {
            this.Hide();                //Hides Computer Form
            Menu f1 = new Menu();       //Create Menu object
            f1.ShowDialog();            //Opens Menu
        }

        private void combo_Tools_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();      //Opens database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Steganography where Tool= '" + combo_Tools.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_Tool.Text = reader["Tool"].ToString();
                    txt_Category.Text = reader["Category"].ToString();
                    txt_Purpose.Text = reader["Purpose"].ToString();
                    txt_Description.Text = reader["Description"].ToString();
                    txt_Launch.Text = reader["Launch"].ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        
    }
}
