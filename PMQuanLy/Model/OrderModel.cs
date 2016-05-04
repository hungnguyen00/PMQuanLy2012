using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace PMQuanLy.Model
{
    class OrderModel:BaseModel
    {
        String table = "list_order";

        public DataTable getAllOrder() 
        {
            String select = " *";
            String where = "";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table, where, arrValues);
        }
    }
}
