using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TTCSDLWeb.Models.DAO;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Models.BUS
{
    public class GroupsubjectBUS
    {
        private GroupsubjectBUS() { }
        private static GroupsubjectBUS instance;

        public static GroupsubjectBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GroupsubjectBUS();
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
            return GroupsubjectDAO.Instance.GetList();
        }

        public DataTable ShowTable()
        {
            return GroupsubjectDAO.Instance.ShowTable();
        }

        public int Add(string name)
        {
            return GroupsubjectDAO.Instance.Add(name);
        }
        public int Edit(string code, string name)
        {
            return GroupsubjectDAO.Instance.Edit(code, name);
        }
        public int Delete(string code)
        {
            return GroupsubjectDAO.Instance.Delete(code);
        }
    }
}