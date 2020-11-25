using NorthwindVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAC
{
    public class OrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public OrderDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        //==================================================

        public List<ProductInfoVO> GetProductAllList()
        {
            string sql = "select ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsOnOrder from Products";
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductInfoVO>  list = Helper.DataReaderMapToList
            }
        }
    }
}
