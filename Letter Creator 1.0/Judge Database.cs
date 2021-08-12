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
    public partial class Judge_Database : Form
    {
        public Judge_Database()
        {
            InitializeComponent();
        }

        private void judgesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.judgesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterCreatorDBDataSet);

        }

        private void Judge_Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'letterCreatorDBDataSet.Judges' table. You can move, or remove it, as needed.
            this.judgesTableAdapter.Fill(this.letterCreatorDBDataSet.Judges);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
