using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.DAO
{
    public class TrainingdetailsDAO
    {
        private TrainingdetailsDAO() { }
        private static TrainingdetailsDAO instance;

        public static TrainingdetailsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrainingdetailsDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Trainingdetails> GetList()
        {
            List<Trainingdetails> list = new List<Trainingdetails>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.trainingdetails");
            foreach (DataRow item in data.Rows)
            {
                Trainingdetails emp = new Trainingdetails(item);
                list.Add(emp);
            }

            return list;
        }

        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.trainingdetails");

            return data;
        }

        public int Add(string subjectcode, string educationspecializecode, string fomality, int semester, string groupsubjectcode)
        {
            string query = $"EXEC dbo.AddTraningdetails @subjectcode = '{subjectcode}', @educationspecializecode = '{educationspecializecode}',  @fomality = N'{fomality}',  @semester = {semester}, @groupsubjectcode = '{groupsubjectcode}' -- varchar(10)";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Edit(string subjectcode, string educationspecializecode, string fomality, int semester, string groupsubjectcode)
        {
            string query = $"EXEC dbo.UpdateTrainingdetails @mamon = '{subjectcode}', @macn='{educationspecializecode}',  @hinhthuc = N'{fomality}',@kihoc = {semester},  @manm = '{groupsubjectcode}'";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(string code)
        {
            string query = $"EXEC dbo.DeleteTrainingDetails @subjectcode = '{code}' ";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}