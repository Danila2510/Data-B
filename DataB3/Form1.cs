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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataB3
{
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = null;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;

                string searchPattern = "*.txt";

                files = Directory.GetFiles(folderPath, searchPattern);

            }
            if (files.Length > 0)
            {
                string filePath = files[0];

                using (StreamReader reader = new StreamReader(filePath))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            string parentText = textBox1.Text;

            form2.textBox1.Text = parentText;

            form2.ShowDialog();

            if(DialogResult.OK == form2.DialogResult)
            {
                textBox1.Text = form2.textBox1.Text;
            }
            else
            {
                form2.Close();
            }
        }
    }
}
