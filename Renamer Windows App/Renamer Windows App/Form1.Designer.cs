namespace Renamer_Windows_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PathLable = new System.Windows.Forms.Label();
            this.ExtentionLable = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ExtentionTextBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SelectPath = new System.Windows.Forms.Button();
            this.fileNumberLable = new System.Windows.Forms.Label();
            this.fileNumber = new System.Windows.Forms.Label();
            this.Rename = new System.Windows.Forms.Button();
            this.CSVFilePathLable = new System.Windows.Forms.Label();
            this.CSVPathTextBox = new System.Windows.Forms.TextBox();
            this.Revert = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectCSVfile = new System.Windows.Forms.Button();
            this.openCSV = new System.Windows.Forms.Button();
            this.DeleteCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulk Renamer";
            // 
            // PathLable
            // 
            this.PathLable.AutoSize = true;
            this.PathLable.Location = new System.Drawing.Point(39, 62);
            this.PathLable.Name = "PathLable";
            this.PathLable.Size = new System.Drawing.Size(37, 17);
            this.PathLable.TabIndex = 1;
            this.PathLable.Text = "Path";
            // 
            // ExtentionLable
            // 
            this.ExtentionLable.AutoSize = true;
            this.ExtentionLable.Location = new System.Drawing.Point(42, 94);
            this.ExtentionLable.Name = "ExtentionLable";
            this.ExtentionLable.Size = new System.Drawing.Size(66, 17);
            this.ExtentionLable.TabIndex = 2;
            this.ExtentionLable.Text = "Extention";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(166, 62);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(343, 22);
            this.PathTextBox.TabIndex = 4;
            // 
            // ExtentionTextBox
            // 
            this.ExtentionTextBox.Location = new System.Drawing.Point(166, 94);
            this.ExtentionTextBox.Name = "ExtentionTextBox";
            this.ExtentionTextBox.Size = new System.Drawing.Size(343, 22);
            this.ExtentionTextBox.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(166, 131);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(76, 386);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 25);
            this.StatusLabel.TabIndex = 13;
            // 
            // SelectPath
            // 
            this.SelectPath.Location = new System.Drawing.Point(515, 61);
            this.SelectPath.Name = "SelectPath";
            this.SelectPath.Size = new System.Drawing.Size(102, 23);
            this.SelectPath.TabIndex = 19;
            this.SelectPath.Text = "Select Folder";
            this.SelectPath.UseVisualStyleBackColor = true;
            this.SelectPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // fileNumberLable
            // 
            this.fileNumberLable.AutoSize = true;
            this.fileNumberLable.Location = new System.Drawing.Point(42, 182);
            this.fileNumberLable.Name = "fileNumberLable";
            this.fileNumberLable.Size = new System.Drawing.Size(107, 17);
            this.fileNumberLable.TabIndex = 8;
            this.fileNumberLable.Text = "Number of Files";
            // 
            // fileNumber
            // 
            this.fileNumber.AutoSize = true;
            this.fileNumber.Location = new System.Drawing.Point(175, 182);
            this.fileNumber.Name = "fileNumber";
            this.fileNumber.Size = new System.Drawing.Size(0, 17);
            this.fileNumber.TabIndex = 9;
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(434, 262);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(75, 23);
            this.Rename.TabIndex = 10;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Visible = false;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // CSVFilePathLable
            // 
            this.CSVFilePathLable.AutoSize = true;
            this.CSVFilePathLable.Location = new System.Drawing.Point(42, 233);
            this.CSVFilePathLable.Name = "CSVFilePathLable";
            this.CSVFilePathLable.Size = new System.Drawing.Size(90, 17);
            this.CSVFilePathLable.TabIndex = 11;
            this.CSVFilePathLable.Text = "CSVFile Path";
            this.CSVFilePathLable.Visible = false;
            // 
            // CSVPathTextBox
            // 
            this.CSVPathTextBox.Location = new System.Drawing.Point(166, 230);
            this.CSVPathTextBox.Name = "CSVPathTextBox";
            this.CSVPathTextBox.ShortcutsEnabled = false;
            this.CSVPathTextBox.Size = new System.Drawing.Size(343, 22);
            this.CSVPathTextBox.TabIndex = 12;
            this.CSVPathTextBox.Visible = false;
            // 
            // Revert
            // 
            this.Revert.Location = new System.Drawing.Point(353, 262);
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(75, 23);
            this.Revert.TabIndex = 14;
            this.Revert.Text = "Revert";
            this.Revert.UseVisualStyleBackColor = true;
            this.Revert.Visible = false;
            this.Revert.Click += new System.EventHandler(this.Revert_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(515, 262);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(102, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "No need to add Extentions for new filenames.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Please Close CSV File after editing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Don\'t use Special Characters or Commas\'";
            // 
            // SelectCSVfile
            // 
            this.SelectCSVfile.Location = new System.Drawing.Point(515, 230);
            this.SelectCSVfile.Name = "SelectCSVfile";
            this.SelectCSVfile.Size = new System.Drawing.Size(102, 23);
            this.SelectCSVfile.TabIndex = 20;
            this.SelectCSVfile.Text = "Select CSV file";
            this.SelectCSVfile.UseVisualStyleBackColor = true;
            this.SelectCSVfile.Visible = false;
            this.SelectCSVfile.Click += new System.EventHandler(this.SelectCSVfile_Click);
            // 
            // openCSV
            // 
            this.openCSV.Location = new System.Drawing.Point(407, 191);
            this.openCSV.Name = "openCSV";
            this.openCSV.Size = new System.Drawing.Size(102, 23);
            this.openCSV.TabIndex = 21;
            this.openCSV.Text = "Open CSV";
            this.openCSV.UseVisualStyleBackColor = true;
            this.openCSV.Visible = false;
            this.openCSV.Click += new System.EventHandler(this.openCSV_Click);
            // 
            // DeleteCSV
            // 
            this.DeleteCSV.Location = new System.Drawing.Point(515, 191);
            this.DeleteCSV.Name = "DeleteCSV";
            this.DeleteCSV.Size = new System.Drawing.Size(102, 23);
            this.DeleteCSV.TabIndex = 22;
            this.DeleteCSV.Text = "Delete CSV";
            this.DeleteCSV.UseVisualStyleBackColor = true;
            this.DeleteCSV.Visible = false;
            this.DeleteCSV.Click += new System.EventHandler(this.DeleteCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 501);
            this.Controls.Add(this.DeleteCSV);
            this.Controls.Add(this.openCSV);
            this.Controls.Add(this.SelectCSVfile);
            this.Controls.Add(this.SelectPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Revert);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CSVPathTextBox);
            this.Controls.Add(this.CSVFilePathLable);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.fileNumber);
            this.Controls.Add(this.fileNumberLable);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ExtentionTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.ExtentionLable);
            this.Controls.Add(this.PathLable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PathLable;
        private System.Windows.Forms.Label ExtentionLable;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox ExtentionTextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button SelectPath;
        private System.Windows.Forms.Label fileNumberLable;
        private System.Windows.Forms.Label fileNumber;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.Label CSVFilePathLable;
        private System.Windows.Forms.TextBox CSVPathTextBox;
        private System.Windows.Forms.Button Revert;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectCSVfile;
        private System.Windows.Forms.Button openCSV;
        private System.Windows.Forms.Button DeleteCSV;
    }
}