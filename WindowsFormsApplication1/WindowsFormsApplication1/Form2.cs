using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            label3.Text = Form5.rng;

            if (calc() == 1)
            {
                label5.Text = "Water sufficient";
               // this.BackgroundImage = Image.FromFile(@"C:\images1.jpg");
            }
            else
            {
                label5.Text = "Water insufficient";
             //   this.BackgroundImage = Image.FromFile(@"C:\drought-617x416.jpg");

            }
        }

        int calc()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCursor<Class2> user = db.GetCollection<Class2>("details").FindAll();
            
            foreach (Class2 i in user)
            {
                if (i.district == Form5.rng)
                {
                    if ((i.current_year - i.needed_rainfall) >= 0)
                        return 1;

                    break;
                        
                }
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
                            f9.Show();
                            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
