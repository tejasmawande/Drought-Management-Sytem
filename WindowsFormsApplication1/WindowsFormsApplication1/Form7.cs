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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        static public string fname = "";
        static public int udt = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            fname = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            udt = 1;

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCollection<Class1> user = db.GetCollection<Class1>("u_signup");
            if (user.Remove(Query.EQ("fname", textBox1.Text)).Ok == true)
                MessageBox.Show("Record Deleted Successfully!");
            else
                MessageBox.Show("Record unable to delete");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ret();
        }
        private void ret()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCursor<Class1> user = db.GetCollection<Class1>("u_signup").FindAll();
            dataGridView1.RowCount = 1;
            foreach(Class1 i in user)
            {
                dataGridView1.Rows.Add(i.fname, i.lname, i.uname, i.password, i.emaila,i.phone);
             }
        }
        private void Delete_Click(object sender,EventArgs e)
        {
            
       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ret();
        }

                

            
    }
}
