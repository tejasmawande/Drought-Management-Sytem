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



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbtest");
            MongoCollection<BsonDocument> student = db.GetCollection<BsonDocument>("Student");
            BsonDocument stud= new BsonDocument
            {
                {"Roll no.",Convert.ToInt32(textBox1.Text.Trim())},
            {"Name",textBox2.Text.Trim()},
            {"Marks",Convert.ToInt32(textBox3.Text.Trim())};
            student.Insert(stud);
                
        }
    }
}
