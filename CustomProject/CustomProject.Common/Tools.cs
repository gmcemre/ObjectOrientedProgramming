using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Common
{
    public static class Tools
    {
        //Singleton Pattern
        private static SqlConnection _Connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCS"].ConnectionString);
                }
                return _Connection;
            }
            set { _Connection = value; }
        }

        public static List<ET> ToList<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET);
            List<ET> list = new List<ET>();

            PropertyInfo[] properties = type.GetProperties();

            foreach (DataRow dr in dt.Rows)
            {
                ET tip = new ET();
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name];
                    if (value != null)
                    {
                        pi.SetValue(tip, value);
                    }
                    list.Add(tip);
                }
            }

            return list;
        }
    }
}
