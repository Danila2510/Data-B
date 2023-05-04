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

namespace DataB
{
    public partial class Finder : Form
    {
        public Form1 frm;
        public Finder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFiles = Directory.GetFiles(textBox1.Text);
            int count = 0;
            foreach (string file in astrFiles)
            {
                if (file.IndexOf(textBox2.Text) != -1)
                    count++;
            }
            listBox1.Items.Add("Всего файлов: " + count);
            foreach (string file in astrFiles)
            {
                if(file.IndexOf(textBox2.Text)!= -1)
                    listBox1.Items.Add(file);
            }
        }
    }
}
