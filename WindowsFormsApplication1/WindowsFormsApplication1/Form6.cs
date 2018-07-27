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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        static public string district = "";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text=dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void ret()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCursor<Class2> user = db.GetCollection<Class2>("details").FindAll();
            dataGridView1.RowCount = 1;
            foreach (Class2 i in user)
            {
                dataGridView1.Rows.Add(i.region, i.district, i.last_year, i.current_year, i.needed_rainfall);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCollection<Class2> user = db.GetCollection<Class2>("details");
            if (user.Remove(Query.EQ("district", textBox1.Text)).Ok == true)
            {
                MessageBox.Show("Record Deleted Successfully!");
                ret();
            }
            else
                MessageBox.Show("Record unable to delete");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }   
    }
}
