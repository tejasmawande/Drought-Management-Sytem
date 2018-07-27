using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string rng = "";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Konkan")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Raigad");
                comboBox2.Items.Add("Mumbai city");
                comboBox2.Items.Add("Mumbai suburban");
                comboBox2.Items.Add("Ratnagiri");
                comboBox2.Items.Add("Sindhudurg");
                comboBox2.Items.Add("Thane");
                comboBox2.Items.Add("Palghar");

            }
            else if (comboBox1.Text == "Vidarbha")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Amravati");
                comboBox2.Items.Add("Akola");
                comboBox2.Items.Add("Bhandara");
                comboBox2.Items.Add("Buldhana");
                comboBox2.Items.Add("Chandrapur");
                comboBox2.Items.Add("Gadchiroli");
                comboBox2.Items.Add("Gondia");
                comboBox2.Items.Add("Nagpur");
                comboBox2.Items.Add("Wardha");
                comboBox2.Items.Add("Washim");
                comboBox2.Items.Add("Yavatmal");

            }
            else if (comboBox1.Text == "Khandesh")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Jalgaon");
                comboBox2.Items.Add("Dhule");
                comboBox2.Items.Add("Nandurbar");
                comboBox2.Items.Add("Nashik");


            }
            else if (comboBox1.Text == "Paschim Maharashtra")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kolhapur");
                comboBox2.Items.Add("Pune");
                comboBox2.Items.Add("Satara");
                comboBox2.Items.Add("Solapur");
                comboBox2.Items.Add("Sangli");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rng = comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}