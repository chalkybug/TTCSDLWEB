using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.DAO
{
    public class GroupsubjectDAO
    {
        private GroupsubjectDAO() { }
        private static GroupsubjectDAO instance;

        public static GroupsubjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GroupsubjectDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Groupsubject> GetList()
        {
            List<Groupsubject> list = new List<Groupsubject>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.groupsubject");
            foreach (DataRow item in data.Rows)
            {
                Groupsubject emp = new Groupsubject(item);
                list.Add(emp);
            }

            return list;
        }

        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.groupsubject");

            return data;
        }

        public int Add(string code, string name)
        {
            string query = $"EXEC dbo.AddGroupsubject @code = '{code}',  @name = N'{name}' -- nvarchar(50)";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Edit(string code, string name)
        {
            string query = $"EXEC dbo.UpdateGoupsubject @code = '{code}',  @name = N'{name}' -- nvarchar(50)";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(string code)
        {
            string query = $"EXEC dbo.DeleteGroupSubject @code = '{code}' ";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

    }
}