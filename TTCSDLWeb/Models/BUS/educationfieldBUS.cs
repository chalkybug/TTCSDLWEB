using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DAO;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.BUS
{
    public class EducationfieldBUS
    {
        private EducationfieldBUS() { }
        private static EducationfieldBUS instance;

        public static EducationfieldBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EducationfieldBUS();
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
            return EducationfieldDAO.Instance.GetList();
        }

        public DataTable ShowTable()
        {
            return EducationfieldDAO.Instance.ShowTable();
        }

        public int Add(string code, string name, string facultycode)
        {
            return EducationfieldDAO.Instance.Add(code,name, facultycode);
        }
        public int Edit(string code, string name, string facultycode)
        {
            return EducationfieldDAO.Instance.Edit(code, name, facultycode);
        }
        public int Delete(string code)
        {
            return EducationfieldDAO.Instance.Delete(code);
        }
    }
}