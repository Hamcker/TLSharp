﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
namespace Models
{
    class Method
    {
        public int id { get; set; }
        public string method { get; set; }
        [Newtonsoft.Json.JsonProperty("params")]
        public List<Param> Params { get; set; } = new List<Param>();
        public string type { get; set; }

    }
    class Param
    {
        public string name { get; set; }
        public string type { get; set; }
    }
    class Constructor
    {
        public int id { get; set; }
        public string predicate { get; set; }
        [Newtonsoft.Json.JsonProperty("params")]
        public List<Param> Params { get; set; } = new List<Param>();
        public string type { get; set; }
    }
    class Schema
    {
        public List<Constructor> constructors { get; set; } = new List<Constructor>();
        public List<Method> methods { get; set; } = new List<Method>();
    }
}
