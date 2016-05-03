using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PMQuanLy.Model
{
    class ListProductModel:BaseModel
    {
        String table = "list_product";

        public DataTable getAllProduct() 
        {
            String select = " * ";
            String where = "";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getProductById(int id)
        {
            String select = " * ";
            String where = "id=@id";
            SQLiteParameter[] arrValues = { new SQLiteParameter("id", id)};
            return selectQuery(select, table, where, arrValues);
        }

        public bool checkProductByProductCode(string productCode)
        {
            String where = "product_code=@product_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("product_code", productCode) };
            return existQuery( table, where, arrValues);
        }
    }
}
