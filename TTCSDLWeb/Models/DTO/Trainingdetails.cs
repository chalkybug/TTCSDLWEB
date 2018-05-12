using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DTO
{
    public class Trainingdetails
    {
        //       subjectcode VARCHAR(10) REFERENCES dbo.subject(code),
        //educationspecializecode VARCHAR(10) ,
        //fomality NVARCHAR(20) ,
        //semester int, 
        //groupsubjectcode varchar(10) REFERENCES dbo.groupsubject(code)

        public string subjectcode { get; set; }
        public string educationspecializecode { get; set; }
        public string fomality { get; set; }
        public int semester { get; set; }
        public string groupsubjectcode { get; set; }


        public Trainingdetails(string subjectcode, string educationspecializecode, string fomality, int semester, string groupsubjectcode)
        {
            this.subjectcode = subjectcode;
            this.educationspecializecode = educationspecializecode;
            this.fomality = fomality;
            this.semester = semester;
            this.groupsubjectcode = groupsubjectcode;
        }

        public Trainingdetails(DataRow row)
        {
            this.subjectcode = row["subjectcode"].ToString();
            this.educationspecializecode = row["educationspecializecode"].ToString();
            this.fomality = row["fomality"].ToString();
            this.semester = int.Parse(row["semester"].ToString());
            this.groupsubjectcode = row["groupsubjectcode"].ToString();
        }

        public Trainingdetails()
        {

        }
    }
}