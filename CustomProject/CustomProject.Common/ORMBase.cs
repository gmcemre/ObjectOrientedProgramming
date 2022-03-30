using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.Common
{
    public class ORMBase<ET> : IORM<ET> where ET : class, new()
    {
        public bool Delete(ET entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ET entity)
        {
            throw new NotImplementedException();
        }

        public List<ET> Select()
        {
            Type type = typeof(ET);
            string query = "select * from ";

            var attributes = type.GetCustomAttributes(typeof(Table), false);
            if (attributes != null && attributes.Any())
            {
                Table table = (Table)attributes[0];
                query += table.TableName;
            }

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Tools.Connection;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt.ToList<ET>();

        }

        public bool Update(ET entity)
        {
            throw new NotImplementedException();
        }
    }
}
