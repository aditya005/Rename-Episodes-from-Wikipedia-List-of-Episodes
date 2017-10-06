using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer_Windows_App
{
    public partial class Form1 : Form
    {
        Renamer r = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string path = PathTextBox.Text + "\\";
            string extention = ExtentionTextBox.Text;
            if (path.Equals("\\")) { StatusLabel.Text = "Please input Path"; return; }
            if (extention.Equals(""))
            {
                r = new Renamer(path);
            }
            else
            {
                r = new Renamer(path, extention);
            }
            fileNumber.Text = r.getfileCsv();
            try
            {
                Convert.ToInt32(r.getfileCsv());
                PathTextBox.ReadOnly = true;
                ExtentionTextBox.ReadOnly = true;
                SelectPath.Visible = false;
                CSVFilePathLable.Visible = true;
                CSVPathTextBox.Visible = true;
                CSVPathTextBox.ReadOnly = false;
                Cancel.Visible = true;
                Rename.Visible = true;
                Revert.Visible = true;
                openCSV.Visible = true;
                DeleteCSV.Visible = true;
                SelectCSVfile.Visible = true;
            }
            catch (Exception)
            {

            }



        }

        private void Rename_Click(object sender, EventArgs e)
        {

            string status = null;
            var v = r.CsvPath;
            if (CSVPathTextBox.Text.Equals(""))
            {
                status = r.renameFile();
            }
            else
            {
                status = r.renameFile(CSVPathTextBox.Text);
            }

            StatusLabel.Text = status;

        }

        private void Revert_Click(object sender, EventArgs e)
        {

            string status;
            if (CSVPathTextBox.Text.Equals(""))
            {
                status = r.revert();
            }
            else
            {
                status = r.revert(CSVPathTextBox.Text);
            }
            StatusLabel.Text = status;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            PathTextBox.ReadOnly = false;
            ExtentionTextBox.ReadOnly = false;
            SelectPath.Visible = true;

            CSVPathTextBox.ReadOnly = true;
            StatusLabel.Text = "";
            Rename.Visible = false;
            Revert.Visible = false;
            Cancel.Visible = false;
            openCSV.Visible = false;
            DeleteCSV.Visible = false;
            SelectCSVfile.Visible = false;



        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdg = new FolderBrowserDialog();
            fdg.Description = "Select Folder";
            fdg.RootFolder = Environment.SpecialFolder.Desktop;

            if (fdg.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = fdg.SelectedPath;
            }
        }

        private void SelectCSVfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = r.Path;
            ofd.Filter = "CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CSVPathTextBox.Text = ofd.FileName;
            }

        }

        private void openCSV_Click(object sender, EventArgs e)
        {
            if (!fileNumber.Text.Equals("0"))
            {
                System.Diagnostics.Process.Start(r.Path + "filenames.csv");
            }

        }

        private void DeleteCSV_Click(object sender, EventArgs e)
        {

            Cancel_Click(sender, e);
            File.Delete(r.Path + "filenames.csv");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}