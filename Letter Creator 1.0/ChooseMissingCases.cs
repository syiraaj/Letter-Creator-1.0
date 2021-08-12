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
    public partial class ChooseMissingCases : Form
    {
        OleDbConnection cn = new OleDbConnection();
        List<string> MissCase = new List<string>();
        List<string> MissCaseNo = new List<string>();

        public ChooseMissingCases(string Date, string Name, string Address)
        {
            InitializeComponent();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Syahirah\Documents\Visual Studio 2010\Projects\Letter Creator 1.0 - Original Version\Letter Creator 1.0\LetterCreatorDB.accdb; Persist Security Info=False;";
        
            textBox1.Text = Name;
            label4.Text = Date;
            label5.Text = Address;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                OleDbCommand cm = new OleDbCommand();
                cm.Connection = cn;

                string query = "SELECT * FROM MissingCases WHERE JudgeName = '" + textBox1.Text + "'";
                cm.CommandText = query;

                OleDbDataReader rd = cm.ExecuteReader();

                while (rd.Read())
                {
                    listBox1.Items.Add(rd["CaseName"].ToString());
                    listBox2.Items.Add(rd["CaseNo"].ToString());
                }
                cn.Close();
            }
            catch
            {
                listBox1.Text = "Error loading address.";
                listBox2.Text = "Error loading address.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count - 1;

            for (int i = count; i >= 0; i--)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox4.Items.Add(listBox1.Items[i]);
                    listBox1.Items.RemoveAt(i);
                    listBox3.Items.Add(listBox2.Items[i]);
                    listBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = listBox4.Items.Count - 1;

            for (int i = count; i >= 0; i--)
            {
                if (listBox4.GetSelected(i))
                {
                    listBox1.Items.Add(listBox4.Items[i]);
                    listBox4.Items.RemoveAt(i);
                    listBox2.Items.Add(listBox3.Items[i]);
                    listBox3.Items.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new ChooseJudge();
            form1.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Date = label4.Text;
            string Name = textBox1.Text;
            string Address = label5.Text;

            foreach (string strA in listBox4.Items)
            {
                MissCase.Add(strA);
            }

            foreach (string strB in listBox3.Items)
            {
                MissCaseNo.Add(strB);
            }

            Form form2 = new ChooseUnreceivedCases(Date, Name, Address, MissCase, MissCaseNo);
            form2.Show();
            this.Close();
        }
    }
}
