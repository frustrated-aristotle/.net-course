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
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // buttonLocationSelect
            // 
            this.buttonLocationSelect.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLocationSelect.Location = new System.Drawing.Point(295, 12);
            this.buttonLocationSelect.Name = "buttonLocationSelect";
            this.buttonLocationSelect.Size = new System.Drawing.Size(121, 53);
            this.buttonLocationSelect.TabIndex = 0;
            this.buttonLocationSelect.Text = "Select Location";
            this.buttonLocationSelect.UseVisualStyleBackColor = true;
            this.buttonLocationSelect.Click += new System.EventHandler(this.buttonLocationSelect_Click);
            // 
            // locationTXT
            // 
            this.locationTXT.AutoSize = true;
            this.locationTXT.Font = new System.Drawing.Font("rainyhearts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationTXT.Location = new System.Drawing.Point(162, 159);
            this.locationTXT.Name = "locationTXT";
            this.locationTXT.Size = new System.Drawing.Size(65, 20);
            this.locationTXT.TabIndex = 1;
            this.locationTXT.Text = "label1";
            this.locationTXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 432);
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
    }
}

