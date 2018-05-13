using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.DAO
{
    public class SubjectDAO
    {
        private SubjectDAO() { }
        private static SubjectDAO instance;

        public static SubjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectDAO();
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
            List<Subject> list = new List<Subject>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.subject");
            foreach (DataRow item in data.Rows)
            {
                Subject emp = new Subject(item);
                list.Add(emp);
            }

            return list;
        }

        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.subject");

            return data;
        }

        public int Add(string code, string codeview, string name, int numberofcredit, int numberoflesson, int numberoftheory, int numberofexercise, int numberofdiscussion, int numberofpractive, string examform)
        {
            string query = $"EXEC dbo.CreateSubject @mamon='{code}',@mahienthi='{codeview}',@tenmon=N'{name}',@sotc={numberofcredit},@sotiet={numberoflesson},@tietlt={numberoftheory},@tietbt ={numberofexercise},@tiettl ={numberofdiscussion},@tietth={numberofpractive},@htthi=N'{examform}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Edit(string code, string codeview, string name, int numberofcredit, int numberoflesson, int numberoftheory, int numberofexercise, int numberofdiscussion, int numberofpractive, string examform)
        {
            string query = $"EXEC UpdateSubject @mamon='{code}',@mahienthi='{codeview}',@tenmon=N'{name}',@sotc={numberofcredit},@sotiet={numberoflesson},@tietlt={numberoftheory},@tietbt ={numberofexercise},@tiettl ={numberofdiscussion},@tietth={numberofpractive},@htthi=N'{examform}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(string code)
        {
            string query = $"EXEC dbo.DeleteSubject @code = '{code}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }


    }
}