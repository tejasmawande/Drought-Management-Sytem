using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace WindowsFormsApplication1
{
    class Class2
    {
        public ObjectId _id { get; set; }
        public string region { get; set; }
        public string district { get; set; }
        public Int32 last_year { get; set; }
        public Int32 current_year { get; set; }
        public Int32 needed_rainfall { get; set; }
    }
}
