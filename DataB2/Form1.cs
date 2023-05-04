using System;
using System.Windows.Forms;
using static DataB2.Form2;

namespace DataB2
{
    public partial class Form1 : Form
    {
        Form2 editr = null;
        public Form1()
        {
            InitializeComponent();
            editr = new Form2();
            foreach (var item in editr.listBox1.Items)
                comboBox1.Items.Add(item);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = double.TryParse(label2.Text, out num1) ? num1 : 0;
            num2 = double.TryParse(label1.Text, out num2) ? num2 : 0;
            result = num1 + num2;
            label2.Text = result.ToString();
            string selectedComponent = comboBox1.SelectedItem.ToString();
            ComputerComponent component = editr.components_.Find(c => c.Name == selectedComponent);
            listBox1.Items.Add(component.Name + ", " + component.Description + ", " + component.Price);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            editr = new Form2();
            editr.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedComponent = comboBox1.SelectedItem.ToString();
            ComputerComponent component = editr.components_.Find(c => c.Name == selectedComponent);
            label1.Text = component.Price.ToString();
        }
    }
}
