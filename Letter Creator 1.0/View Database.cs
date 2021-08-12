using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Letter_Creator_1._0
{
    public partial class View_Database : Form
    {
        public View_Database()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Judge_Database();
            form1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Missing_Case_Database();
            form1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Unreceived_Cases_Database();
            form1.Show();
        }
    }
}
