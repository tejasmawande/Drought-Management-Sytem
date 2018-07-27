using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
namespace WindowsFormsApplication1
{
    class Class1
    {

        public ObjectId _id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public string emaila { get; set; }
        public string phone { get; set; }


    }
}
