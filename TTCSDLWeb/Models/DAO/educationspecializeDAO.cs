using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.DAO
{
    public class EducationspecializeDAO
    {
        private EducationspecializeDAO() { }
        private static EducationspecializeDAO instance;

        public static EducationspecializeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EducationspecializeDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Educationspecialize> GetList()
        {
            List<Educationspecialize> list = new List<Educationspecialize>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.educationspecialize");
            foreach (DataRow item in data.Rows)
            {
                Educationspecialize emp = new Educationspecialize(item);
                list.Add(emp);
            }

            return list;
        }

        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.educationspecialize");

            return data;
        }

        public int Add(string code, string codeview, string name, string educationfieldcode)
        { 
            string query = $"EXEC AddEducationspecialize'{code}', '{codeview}', N'{name}', N'{educationfieldcode}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Edit(string code, string codeview, string name, string educationfieldcode)
        {
            string query = $"EXEC UpdateEducationspecialize'{code}', '{codeview}', N'{name}', N'{educationfieldcode}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(string code)
        {
            string query = $"EXEC dbo.DeleteEducationSpecialize @code = '{code}'   ";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }


        public List<Educationspecialize> Search(string name)
        {
            List<Educationspecialize> list = new List<Educationspecialize>();

            DataTable data = DataProvider.Instance.ExecuteQuery($"SELECT * FROM dbo.educationspecialize WHERE name LIKE '%{name}%'");
            foreach (DataRow item in data.Rows)
            {
                Educationspecialize emp = new Educationspecialize(item);
                list.Add(emp);
            }

            return list;
        }
    }
}