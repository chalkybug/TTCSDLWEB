using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DTO
{
    public class Educationspecialize
    {
        //        code VARCHAR(10) PRIMARY KEY,
        //codeview VARCHAR(20),
        //	name NVARCHAR(80),
        //	educationfieldcode VARCHAR(10),
        public string code { get; set; }
        public string codeview { get; set; }
        public string name { get; set; }
        public string educationfieldcode { get; set; }


        public Educationspecialize(string code, string codeview, string name, string educationfieldcode)
        {
            this.code = code;
            this.codeview = codeview;
            this.name = name;
            this.educationfieldcode = educationfieldcode;

        }

        public Educationspecialize(DataRow row)
        {
            this.code = row["code"].ToString();
            this.codeview = row["codeview"].ToString();
            this.name = row["name"].ToString();
            this.educationfieldcode = row["educationfieldcode"].ToString();

        }

        public Educationspecialize() { }





    }
}