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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ret()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dms");
            MongoCursor<Class3> user = db.GetCollection<Class3>("districtdist").FindAll();
            dataGridView1.RowCount = 1;
            foreach (Class3 i in user)
            {
                if(Form5.rng==i.ED)
                {
                     dataGridView1.Rows.Add(i.OD, Convert.ToString(i.dist));
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ret();
        }
    }
}
