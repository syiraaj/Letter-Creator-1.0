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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form1 = new ChooseJudge();
            form1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form1 = new View_Database();
            form1.Show();
        }
    }
}
