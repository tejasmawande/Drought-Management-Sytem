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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCollection<BsonDocument> user = db.GetCollection<BsonDocument>("u_signup");
            BsonDocument signup = new BsonDocument
            {
                {"fname",textBox1.Text.Trim()},
                {"lname",textBox2.Text.Trim()},
                {"uname",textBox3.Text.Trim()},
                {"password",textBox4.Text.Trim()},
                {"confirm_password",textBox5.Text.Trim()},
                {"emaila",textBox6.Text.Trim()},
                {"phone",textBox7.Text.Trim()}
            };
            user.Insert(signup);
            MessageBox.Show("User Add Successfully!");
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button2.Hide();
            if (Form7.udt == 1)
            {
                button2.Show();
                fill();
            }
        }
        void fill()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCursor<Class1> user = db.GetCollection<Class1>("u_signup").FindAll();
            foreach (Class1 i in user)
            {
                if (Form7.fname == i.fname)
                {
                    textBox1.Text = i.fname;
                    textBox2.Text = i.lname;
                    textBox3.Text = i.uname;
                    textBox6.Text = i.emaila;
                    textBox7.Text = i.phone;

                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dms");
                MongoCollection<Class1> stud = db.GetCollection<Class1>("u_signup");
                foreach (Class1 i in stud.Find(Query.EQ("fname", textBox1.Text.Trim())))
                {
                    IMongoUpdate update1 = new UpdateDocument();
                    IMongoUpdate update2 = new UpdateDocument();
                    IMongoUpdate update3 = new UpdateDocument();
                    IMongoUpdate update4 = new UpdateDocument();
                    IMongoUpdate update5 = new UpdateDocument();
                    if (textBox1.Text != "")
                    {
                        update1 = MongoDB.Driver.Builders.Update.Set("fname", textBox1.Text);
                        update2 = MongoDB.Driver.Builders.Update.Set("lname", textBox2.Text);
                        update3 = MongoDB.Driver.Builders.Update.Set("uname", textBox3.Text);
                        update4 = MongoDB.Driver.Builders.Update.Set("emaila", textBox6.Text);
                        update5 = MongoDB.Driver.Builders.Update.Set("phone", textBox7.Text);
                    }
                    stud.Update(Query.EQ("fname", textBox1.Text), update2);
                    stud.Update(Query.EQ("fname", textBox1.Text), update3);
                    stud.Update(Query.EQ("fname", textBox1.Text), update4);
                    stud.Update(Query.EQ("fname", textBox1.Text), update5);
                    stud.Update(Query.EQ("fname", textBox1.Text), update1);

                    MessageBox.Show("Updated");
                    //  refresh();
                    break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
