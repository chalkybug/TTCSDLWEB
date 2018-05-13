using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DAO;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.BUS
{
    public class SubjectBUS
    {
        private SubjectBUS() { }
        private static SubjectBUS instance;

        public static SubjectBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectBUS();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Subject> GetList()
        {
            return SubjectDAO.Instance.GetList();
        }

        public DataTable ShowTable()
        {
            return SubjectDAO.Instance.ShowTable();
        }

        public int Add(string code, string codeview, string name, int numberofcredit, int numberoflesson, int numberoftheory, int numberofexercise, int numberofdiscussion, int numberofpractive, string examform)
        {
            return SubjectDAO.Instance.Add(code, codeview, name, numberofcredit, numberoflesson, numberoftheory, numberofexercise, numberofdiscussion, numberofpractive, examform);
        }
        public int Edit(string code, string codeview, string name, int numberofcredit, int numberoflesson, int numberoftheory, int numberofexercise, int numberofdiscussion, int numberofpractive, string examform)
        {
            return SubjectDAO.Instance.Edit(code, codeview, name, numberofcredit, numberoflesson, numberoftheory, numberofexercise, numberofdiscussion, numberofpractive, examform);
        }
        public int Delete(string code)
        {
            return SubjectDAO.Instance.Delete(code);
        }

    }
}