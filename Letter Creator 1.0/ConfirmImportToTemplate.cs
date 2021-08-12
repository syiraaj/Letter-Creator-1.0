using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Letter_Creator_1._0
{
    public partial class ConfirmImportToTemplate : Form
    {
        string Date_Sent, Judge_Name, Judge_Address;
        List<string> CaseName = new List<string>();
        List<string> CaseNo = new List<string>();

        public ConfirmImportToTemplate(string Date, string Judge, string Address, List<string>CaseNames, List<string>CaseNos)
        {
            InitializeComponent();

            Date_Sent = Date;
            Judge_Name = Judge;
            Judge_Address = Address;

            foreach (string A in CaseNames)
            {
                CaseName.Add(A);
            }

            foreach (string B in CaseNos)
            {
                CaseNo.Add(B);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
