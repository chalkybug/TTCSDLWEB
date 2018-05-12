using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DTO
{
    public class Groupsubject
    {
        public string code { get; set; }
        public string name { get; set; }


        public Groupsubject(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
        public Groupsubject(DataRow row)
        {
            this.code = row["code"].ToString();
            this.name = row["name"].ToString();
        }

        public Groupsubject() { }
    }
}