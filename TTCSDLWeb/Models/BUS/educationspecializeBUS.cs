using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DAO;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.BUS
{
    public class EducationspecializeBUS
    {

        private EducationspecializeBUS() { }
        private static EducationspecializeBUS instance;

        public static EducationspecializeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EducationspecializeBUS();
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
            return EducationspecializeDAO.Instance.GetList();
        }

        public DataTable ShowTable()
        {
            return EducationspecializeDAO.Instance.ShowTable();
        }

        public int Add(string code, string codeview, string name, string educationfieldcode)
        {
            return EducationspecializeDAO.Instance.Add(code, codeview, name, educationfieldcode);
        }
        public int Edit(string code, string codeview, string name, string educationfieldcode)
        {
            return EducationspecializeDAO.Instance.Edit(code, codeview, name, educationfieldcode);
        }
        public int Delete(string code)
        {
            return EducationspecializeDAO.Instance.Delete(code);
        }

    }
}