using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pet pet;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = textBox2.Text;
            decimal age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(textBox3.Text, out age))
            {
                pet = new Pet(name, type, age);
            } else
            {
                MessageBox.Show("Please correct your input", "Invalid Input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lstOutput.Items.Add("Pet's name: " + pet.Name);
                lstOutput.Items.Add("Pet's type: " + pet.Type);
                lstOutput.Items.Add("Pet's age: " + pet.Age);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please enter the pet data first!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
