using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Letter_Creator_1._0
{
    public partial class ChooseJudge : Form
    {
        OleDbConnection cn = new OleDbConnection();

        public ChooseJudge()
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Syahirah\Documents\Visual Studio 2010\Projects\Letter Creator 1.0 - Original Version\Letter Creator 1.0\LetterCreatorDB.accdb; Persist Security Info=False;";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //get date of letter written
            DateTime today = new DateTime();
            today = DateTime.UtcNow.Date;

            //change date format to formal letter date format
            string date = today.ToString("dd MMMM yyyy");
            textBox1.Text = date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Judge_Name = comboBox1.Text;
            string Judge_Address = textBox2.Text;
            string Date_Sent = textBox1.Text;
            Form form1 = new ChooseMissingCases(Date_Sent, Judge_Name, Judge_Address);
            form1.Show();
            this.Close();
        }

        private void ChooseJudge_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                OleDbCommand cm = new OleDbCommand();
                cm.Connection = cn;

                string query = "SELECT * FROM Judges";
                cm.CommandText = query;

                OleDbDataReader rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    comboBox1.Items.Add(rd["JudgeName"].ToString());
                }
                cn.Close();
            }
            catch
            {
                comboBox1.Text = "Error loading list.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                OleDbCommand cm = new OleDbCommand();
                cm.Connection = cn;

                string query = "SELECT * FROM Judges WHERE JudgeName = '" + comboBox1.Text + "'";
                cm.CommandText = query;

                OleDbDataReader rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    textBox2.Text = rd["Address"].ToString();
                }
                cn.Close();
            }
            catch
            {
                textBox2.Text = "Error loading address.";
            }
        }
    }
}
