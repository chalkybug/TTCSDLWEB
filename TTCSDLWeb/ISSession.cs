using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTCSDLWeb
{
    public class IsSession
    {
        public int setKey(string key, object value)
        {
            System.Web.HttpContext.Current.Session[key] = value;
            return 0;
        }
        /// <summary>
        /// Lấy giá trị key, trong trường hợp không tồn tại sẽ trả về defaultValue
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public object getKey(string key, object defaultValue)
        {
            if (System.Web.HttpContext.Current.Session[key] == null)
            {
                return defaultValue;
            }
            return System.Web.HttpContext.Current.Session[key];

        }


        public int login()
        {
            System.Web.HttpContext.Current.Session["Login_Info"] = "user1";
            //assign for later
            return 0;
        }

        /// <summary>
        /// Remove login information
        /// </summary>
        /// <returns></returns>
        public int logout()
        {
            System.Web.HttpContext.Current.Session["Login_Info"] = null;
            return 0;
        }
        /// <summary>
        /// Check the login status, 0 is logined
        /// </summary>
        /// <returns>-1: not yet, 0 is logged</returns>
        public int isLogin()
        {
            if (System.Web.HttpContext.Current.Session["Login_Info"] == null)
            {
                return -1;
            }
           
            return 0;
        }


        public int func(string key)
        {
            return 15;
        }

    }
}