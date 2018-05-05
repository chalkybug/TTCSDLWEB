using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DTO
{
    public class Subject
    {
        public string code { get; set; }
        public string codeview { get; set; }
        public string name { get; set; }
        public int numberofcredit { get; set; }
        public int numberoflesson { get; set; }
        public int numberoftheory { get; set; }
        public int numberofexercise { get; set; }
        public int numberofdiscussion { get; set; }
        public int numberofpractive { get; set; }
        public string examform { get; set; }

        public Subject(string code, string codeview, string name, int numberofcredit, int numberoflesson, int numberoftheory, int numberofexercise, int numberofdiscussion, int numberofpractive, string examform)
        {
            this.code = code;
            this.codeview = codeview;
            this.name = name;
            this.numberofcredit = numberofcredit;
            this.numberoflesson = numberoflesson;
            this.numberoftheory = numberoftheory;
            this.numberofexercise = numberofexercise;
            this.numberofdiscussion = numberofdiscussion;
            this.numberofpractive = numberofpractive;
            this.examform = examform;
        }
        public Subject(DataRow row)
        {
            this.code = row["code"].ToString();
            this.codeview = row["codeview"].ToString();
            this.name = row["name"].ToString();
            this.numberofcredit = int.Parse(row["numberofcredit"].ToString());
            this.numberoflesson = int.Parse(row["numberoflesson"].ToString());
            this.numberoftheory = int.Parse(row["numberoftheory"].ToString());
            this.numberofexercise = int.Parse(row["numberofexercise"].ToString());
            this.numberofdiscussion = int.Parse(row["numberofdiscussion"].ToString());
            this.numberofpractive = int.Parse(row["numberofpractive"].ToString());
            this.examform = row["examform"].ToString();
        }
        public Subject() { }

    }
}