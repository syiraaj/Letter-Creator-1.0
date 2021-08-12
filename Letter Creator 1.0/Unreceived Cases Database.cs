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
    public partial class Unreceived_Cases_Database : Form
    {
        public Unreceived_Cases_Database()
        {
            InitializeComponent();
        }

        private void unreceivedCasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unreceivedCasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterCreatorDBDataSet1);

        }

        private void Unreceived_Cases_Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'letterCreatorDBDataSet1.UnreceivedCases' table. You can move, or remove it, as needed.
            this.unreceivedCasesTableAdapter.Fill(this.letterCreatorDBDataSet1.UnreceivedCases);
            // TODO: This line of code loads data into the 'letterCreatorDBDataSet.UnreceivedCases' table. You can move, or remove it, as needed.
            this.unreceivedCasesTableAdapter.Fill(this.letterCreatorDBDataSet1.UnreceivedCases);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unreceivedCasesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.unreceivedCasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterCreatorDBDataSet1);

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
