using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.DAO
{
    public class EducationfieldDAO
    {
        private EducationfieldDAO() { }
        private static EducationfieldDAO instance;

        public static EducationfieldDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EducationfieldDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Educationfield> GetList()
        {
            List<Educationfield> list = new List<Educationfield>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.educationfield");
            foreach (DataRow item in data.Rows)
            {
                Educationfield emp = new Educationfield(item);
                list.Add(emp);
            }

            return list;
        }

        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.educationfield");

            return data;
        }

        public int Add(string name, string facultycode)
        {
            string query = $"";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Edit(string code, string name, string facultycode)
        {
            string query = $"";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(string code)
        {
            string query = $"";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

    }
}