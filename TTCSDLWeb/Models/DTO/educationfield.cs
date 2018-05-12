using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DTO
{
    public class Educationfield
    {
        //        code VARCHAR(10) PRIMARY KEY,
        //name NVARCHAR(80),
        //	facultycode VARCHAR(10) REFERENCES dbo.faculty(code)

        public string code { get; set; }
        public string name { get; set; }
        public string facultycode { get; set; }


        public Educationfield(string code, string name, string facultycode)
        {
            this.code = code;
            this.name = name;
            this.facultycode = facultycode;
        }
        public Educationfield(DataRow row)
        {
            this.code = row["code"].ToString();
            this.name = row["name"].ToString();
            this.facultycode = row["facultycode"].ToString();
        }

        public Educationfield() { }
    }
}