using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

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
        public DataTable getProductByProductCode(string productCode)
        {
            String select = " * ";
            String where = "product_code=@product_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("product_code", productCode) };
            return selectQuery(select, table, where, arrValues);
        }
        public bool insertNewProduct(Hashtable arrCol)
        {
            bool result = false;
            if (checkProductByProductCode(arrCol["product_code"].ToString())) // already on DB
            {
                result = true;
            }
            else
            {
                result = insertQuery(table, arrCol);
            }
            return result;
        }
        public void addQuantityByProductCode(String product_code)
        {
            String query = "UPDATE " + table + " SET quantity=quantity+1 WHERE product_code=@product_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("product_code", product_code) };

            updateQueryDirectly(query, arrValues);;
        }
    }
}
