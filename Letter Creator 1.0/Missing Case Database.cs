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
    public partial class Missing_Case_Database : Form
    {
        public Missing_Case_Database()
        {
            InitializeComponent();
        }

        private void missingCasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.missingCasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterCreatorDBDataSet1);

        }

        private void Missing_Case_Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'letterCreatorDBDataSet1.MissingCases' table. You can move, or remove it, as needed.
            this.missingCasesTableAdapter.Fill(this.letterCreatorDBDataSet1.MissingCases);
            // TODO: This line of code loads data into the 'letterCreatorDBDataSet.MissingCases' table. You can move, or remove it, as needed.
            this.missingCasesTableAdapter.Fill(this.letterCreatorDBDataSet1.MissingCases);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void missingCasesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.missingCasesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterCreatorDBDataSet1);

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
