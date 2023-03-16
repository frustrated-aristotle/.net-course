using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Dosya_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLocationSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            locationTXT.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            locationTXT.Text = openFileDialog1.FileName;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileDir= folderBrowserDialog1.SelectedPath;
                fileDirectoryTXT.Text = fileDir;
            }
        }

        string fileDir, fileName;

        private void buttonReadTXT_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                string line = read.ReadLine();

                while(line != null)
                {
                    listBox1.Items.Add(line);
                    line = read.ReadLine();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileName = fileNameTXT.Text;
            string path = fileDir + "\\" + fileName + ".txt"; 
            StreamWriter sw = File.CreateText(path);
            MessageBox.Show("Your file has been succesfully created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
