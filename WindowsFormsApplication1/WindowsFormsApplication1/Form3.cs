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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int ad = -1;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide(); this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ad = 1;
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ad = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dms");
                MongoCursor<Class1> put = db.GetCollection<Class1>("u_signup").FindAll();
                foreach (Class1 i in put)
                {
                    if (textBox1.Text == i.uname && textBox2.Text == i.password)
                    {
                        if (ad == 0)
                        {
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        else if (ad == 1)
                        {
                            Form5 f5 = new Form5();
                            f5.Show();
                            this.Hide();

                        }
                        else
                            MessageBox.Show("Select User Type!");

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
