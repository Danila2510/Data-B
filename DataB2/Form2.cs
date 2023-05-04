using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataB2
{
    public partial class Form2 : Form
    {
        public List<ComputerComponent> components_ = new List<ComputerComponent>(); 
        public class ComputerComponent
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public ComputerComponent(string name, string description, decimal price)
            {
                Name = name;
                Description = description;
                Price = price;
            }
            public ComputerComponent(ComputerComponent computer)
            {
                Name = computer.Name;
                Description = computer.Description;
                Price = computer.Price;
            }
            public ComputerComponent(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public Form2()
        {
            InitializeComponent();
            components_.Add(new ComputerComponent("Процессор (CPU)", "Описание процессора", 10000m));
            components_.Add(new ComputerComponent("Оперативная память (RAM)", "Описание оперативной памяти", 5000m));
            components_.Add(new ComputerComponent("Жесткий диск (HDD)", "Описание жесткого диска", 8000m));
            components_.Add(new ComputerComponent("Твердотельный накопитель (SSD)", "Описание твердотельного накопителя", 12000m));
            components_.Add(new ComputerComponent("Материнская плата (Motherboard)", "Описание материнской платы", 9000m));
            components_.Add(new ComputerComponent("Видеокарта (GPU)", "Описание видеокарты", 15000m));
            components_.Add(new ComputerComponent("Звуковая карта (Sound Card)", "Описание звуковой карты", 3000m));
            components_.Add(new ComputerComponent("Блок питания (Power Supply Unit)", "Описание блока питания", 6000m));
            components_.Add(new ComputerComponent("Охлаждение (Cooling System)", "Описание системы охлаждения", 4000m));
            components_.Add(new ComputerComponent("Корпус (Case)", "Описание корпуса", 7000m));
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (ComputerComponent component in components_)
            {
                listBox1.Items.Add(component.Name);
                listBox2.Items.Add(component.Description);
                listBox3.Items.Add($" {component.Price} $");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text; 
            decimal price = decimal.Parse(textBox3.Text);
            ComputerComponent componenty = new ComputerComponent(name, description, price);
            components_.Add(componenty);
            RefreshList();
        }
        private void RefreshList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (ComputerComponent component in components_)
            {
                listBox1.Items.Add(component.Name);
                listBox2.Items.Add(component.Description);
                listBox3.Items.Add($" {component.Price} $");
            }
        }
    }
}
