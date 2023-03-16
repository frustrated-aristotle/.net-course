namespace Dosya_Islemleri
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonLocationSelect = new System.Windows.Forms.Button();
            this.locationTXT = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDirectoryTXT = new System.Windows.Forms.TextBox();
            this.fileNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReadTXT = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonWriteToTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // buttonLocationSelect
            // 
            this.buttonLocationSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonLocationSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonLocationSelect.FlatAppearance.BorderSize = 5;
            this.buttonLocationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLocationSelect.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLocationSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.buttonLocationSelect.Location = new System.Drawing.Point(902, 12);
            this.buttonLocationSelect.Name = "buttonLocationSelect";
            this.buttonLocationSelect.Size = new System.Drawing.Size(121, 53);
            this.buttonLocationSelect.TabIndex = 0;
            this.buttonLocationSelect.Text = "Select Location";
            this.buttonLocationSelect.UseVisualStyleBackColor = false;
            this.buttonLocationSelect.Click += new System.EventHandler(this.buttonLocationSelect_Click);
            // 
            // locationTXT
            // 
            this.locationTXT.AutoSize = true;
            this.locationTXT.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.locationTXT.Location = new System.Drawing.Point(178, 396);
            this.locationTXT.Name = "locationTXT";
            this.locationTXT.Size = new System.Drawing.Size(65, 20);
            this.locationTXT.TabIndex = 1;
            this.locationTXT.Text = "label1";
            this.locationTXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonSelectFile.FlatAppearance.BorderSize = 5;
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectFile.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.buttonSelectFile.Location = new System.Drawing.Point(902, 88);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(121, 60);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = false;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonSaveFile.FlatAppearance.BorderSize = 5;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveFile.Font = new System.Drawing.Font("rainyhearts", 16F, System.Drawing.FontStyle.Bold);
            this.buttonSaveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.buttonSaveFile.Location = new System.Drawing.Point(902, 175);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(121, 60);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Directory:";
            // 
            // fileDirectoryTXT
            // 
            this.fileDirectoryTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.fileDirectoryTXT.Font = new System.Drawing.Font("rainyhearts", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileDirectoryTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.fileDirectoryTXT.Location = new System.Drawing.Point(182, 30);
            this.fileDirectoryTXT.Name = "fileDirectoryTXT";
            this.fileDirectoryTXT.Size = new System.Drawing.Size(193, 19);
            this.fileDirectoryTXT.TabIndex = 5;
            // 
            // fileNameTXT
            // 
            this.fileNameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.fileNameTXT.Font = new System.Drawing.Font("rainyhearts", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.fileNameTXT.Location = new System.Drawing.Point(182, 110);
            this.fileNameTXT.Name = "fileNameTXT";
            this.fileNameTXT.Size = new System.Drawing.Size(193, 19);
            this.fileNameTXT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(59, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("rainyhearts", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.button2.Location = new System.Drawing.Point(182, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select Directory";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("rainyhearts", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.button1.Location = new System.Drawing.Point(182, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReadTXT
            // 
            this.buttonReadTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonReadTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonReadTXT.FlatAppearance.BorderSize = 5;
            this.buttonReadTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReadTXT.Font = new System.Drawing.Font("rainyhearts", 16F, System.Drawing.FontStyle.Bold);
            this.buttonReadTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.buttonReadTXT.Location = new System.Drawing.Point(182, 276);
            this.buttonReadTXT.Name = "buttonReadTXT";
            this.buttonReadTXT.Size = new System.Drawing.Size(193, 27);
            this.buttonReadTXT.TabIndex = 11;
            this.buttonReadTXT.Text = "Read A TXT";
            this.buttonReadTXT.UseVisualStyleBackColor = false;
            this.buttonReadTXT.Click += new System.EventHandler(this.buttonReadTXT_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.listBox1.Font = new System.Drawing.Font("rainyhearts", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 10;
            this.listBox1.Location = new System.Drawing.Point(27, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 34);
            this.listBox1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.richTextBox1.Font = new System.Drawing.Font("rainyhearts", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.richTextBox1.Location = new System.Drawing.Point(27, 251);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 176);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // buttonWriteToTXT
            // 
            this.buttonWriteToTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonWriteToTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(129)))));
            this.buttonWriteToTXT.FlatAppearance.BorderSize = 5;
            this.buttonWriteToTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWriteToTXT.Font = new System.Drawing.Font("rainyhearts", 16F, System.Drawing.FontStyle.Bold);
            this.buttonWriteToTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.buttonWriteToTXT.Location = new System.Drawing.Point(182, 334);
            this.buttonWriteToTXT.Name = "buttonWriteToTXT";
            this.buttonWriteToTXT.Size = new System.Drawing.Size(193, 27);
            this.buttonWriteToTXT.TabIndex = 14;
            this.buttonWriteToTXT.Text = "Write to TXT";
            this.buttonWriteToTXT.UseVisualStyleBackColor = false;
            this.buttonWriteToTXT.Click += new System.EventHandler(this.buttonWriteToTXT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1055, 463);
            this.Controls.Add(this.buttonWriteToTXT);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReadTXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileNameTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileDirectoryTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.locationTXT);
            this.Controls.Add(this.buttonLocationSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonLocationSelect;
        private System.Windows.Forms.Label locationTXT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileDirectoryTXT;
        private System.Windows.Forms.TextBox fileNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReadTXT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonWriteToTXT;
    }
}

