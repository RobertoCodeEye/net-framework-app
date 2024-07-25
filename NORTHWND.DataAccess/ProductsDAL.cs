using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NORTHWND.Entities;
using System.Data.SqlClient;
using System.Data;

namespace NORTHWND.DataAccess
{
    public class ProductsDAL:Connection
    {
        
        public List<Products> SelectAll()
        {
            List<Products> listado = new List<Products>();
            string query = "SELECT * FROM Products";

            using (SqlConnection conn = new SqlConnection(cadena))
            {            
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Products _entity = new Products();
                                _entity.ProductID = dr.GetInt32(0);
                                _entity.ProductName = dr.GetString(1);
                                _entity.SupplierID = dr.GetInt32(2);
                                _entity.CategoryID = dr.GetInt32(3);
                                _entity.QuantityPerUnit = dr.GetString(4);
                                _entity.UnitPrice = dr.GetDecimal(5);
                                _entity.UnitsInStock = dr.GetInt16(6);
                                _entity.UnitsOnOrder = dr.GetInt16(7);
                                _entity.ReorderLevel = dr.GetInt16(8);
                                _entity.Discontinued = dr.GetBoolean(9);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
