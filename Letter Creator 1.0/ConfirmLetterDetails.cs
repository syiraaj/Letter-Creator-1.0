using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Letter_Creator_1._0
{
    public partial class ConfirmLetterDetails : Form
    {
        List<string> AllCaseName = new List<string>();
        List<string> AllCaseNo = new List<string>();

        public ConfirmLetterDetails(string Date_Sent, string Judge_Name, string Judge_Address, List<string> CaseName, List<string> CaseNo)
        {
            InitializeComponent();
            textBox1.Text = Date_Sent;
            textBox2.Text = Judge_Name;
            textBox3.Text = Judge_Address;

            string line = "";

            for (int i = 0; i < CaseName.Count(); i++)
            {
                var strA = CaseName[i];

                line = strA.ToString();
                int num = i + 1;

                listBox1.Items.Add(num + ". " + line);
                AllCaseName.Add(num + ". " + line);
            }

            for (int i = 0; i < CaseNo.Count(); i++)
            {
                var strB = CaseNo[i];

                line = strB.ToString();
                int num = i + 1;

                listBox2.Items.Add(num + ". " + line);
                AllCaseNo.Add(num + ". " + line);
            }
        }

        //Methode Find and Replace:
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }

        //Methode Create the document :
        private void CreateWordDocument(object filename, object saveAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            string tempPath = null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();

                string text1 = "";
                for (int i = 0; i < AllCaseName.Count(); i++)
                {
                    var item = AllCaseName[i];
                    text1 += item.ToString() + "\v";
                }

                string text2 = "";
                for (int i = 0; i < AllCaseNo.Count(); i++)
                {
                    var item = AllCaseNo[i];
                    text2 += item.ToString() + "\v";
                }
                //Find and replace:
                this.FindAndReplace(wordApp, "<Date_Sent>", textBox1.Text);
                this.FindAndReplace(wordApp, "<Judge_Name>", textBox2.Text);
                this.FindAndReplace(wordApp, "<Judge_Address>", textBox3.Text);
                this.FindAndReplace(wordApp, "<CaseName>", text1);
                this.FindAndReplace(wordApp, "<CaseNo>", text2);
                             

                #region Print Document :
                /*object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document document = aDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    document.PrintOut(
                    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                */
                #endregion

            }
            else
            {
                MessageBox.Show("File dose not exist.");
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            //File.Delete(tempPath);
            MessageBox.Show("File created.");
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }

        //Méthode Enabled Controles:
        private void tEnabled(bool state)
        {
            textBox1.Enabled = state;
            textBox2.Enabled = state;
            textBox3.Enabled = state;
            listBox1.Enabled = state;
            listBox2.Enabled = state;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form1 = new ChooseJudge();
            form1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            saveDoc.Filter = "Word Document|*.docx";
            saveDoc.FileName = "Surat Alasan Penghakiman " + textBox2.Text;
            saveDoc.DefaultExt = "*.docx";

            if (saveDoc.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(textBox4.Text, saveDoc.FileName);
                tEnabled(false);
                //printDocument1.DocumentName = SaveDoc.FileName;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (loadDoc.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = loadDoc.FileName;
                tEnabled(true);
            }
        }
    }
}
