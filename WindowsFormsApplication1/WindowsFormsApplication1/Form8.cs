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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d;
            if (int.TryParse(textBox1.Text, out d))
            {


                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dms");
                MongoCollection<BsonDocument> admin = db.GetCollection<BsonDocument>("districtdist");
                BsonDocument dist = new BsonDocument

            {
                {"ED",comboBox1.Text.Trim()},
                {"OD",comboBox2.Text.Trim()},
                {"dist",textBox1.Text.Trim()}
            };
                admin.Insert(dist);
                MessageBox.Show("Record added Successfully!");
            }
            else
                MessageBox.Show("Enter Valid Distance");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}