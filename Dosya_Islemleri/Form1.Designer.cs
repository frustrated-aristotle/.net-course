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
            this.locationTXT.Location = new System.Drawing.Point(532, 317);
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
            this.buttonSaveFile.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSaveFile.Location = new System.Drawing.Point(902, 175);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(121, 97);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1055, 463);
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
    }
}

