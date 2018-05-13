using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DAO;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.BUS
{
    public class TrainingdetailsBUS
    {
        private TrainingdetailsBUS() { }
        private static TrainingdetailsBUS instance;

        public static TrainingdetailsBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrainingdetailsBUS();
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
            return TrainingdetailsDAO.Instance.GetList();
        }

        public DataTable ShowTable()
        {
            return TrainingdetailsDAO.Instance.ShowTable();
        }

        public int Add(string subjectcode, string educationspecializecode, string fomality, int semester, string groupsubjectcode)
        {
            return TrainingdetailsDAO.Instance.Add(subjectcode, educationspecializecode, fomality, semester, groupsubjectcode);
        }
        public int Edit(string subjectcode, string educationspecializecode, string fomality, int semester, string groupsubjectcode)
        {
            return TrainingdetailsDAO.Instance.Edit(subjectcode, educationspecializecode, fomality, semester, groupsubjectcode);
        }
        public int Delete(string code)
        {
            return TrainingdetailsDAO.Instance.Delete(code);
        }
    }
}