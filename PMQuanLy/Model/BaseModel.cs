using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace PMQuanLy.Model
{
    class BaseModel
    {
        protected SQLiteConnection conn;
        protected SQLiteCommand cmd;
        protected SQLiteDataAdapter adapter;
        protected DataTable dt1;

        //String cnnString = System.IO.Directory.GetCurrentDirectory() + "/../../quanly_db.db";
        String cnnString = System.IO.Directory.GetCurrentDirectory() + "/quanly_db.db";

        protected void startConnect()
        {
            if (cmd == null) 
            {
                conn = new SQLiteConnection();

                //cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();
                adapter = new SQLiteDataAdapter();

                //conn.ConnectionString = @"data source=E:\visual_workspace\PMQuanLy2012\PMQuanLy\quanly_db.sqlite";
                conn.ConnectionString = @"data source=" + cnnString;
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
            }
        }
        protected void stopConnect()
        {
            if (cmd != null) 
            {
                conn.Close();
                cmd = null;
                adapter = null;
            }
        }
        protected DataTable selectQuery(String select, String from, String where, SQLiteParameter[] arrValues)
        {
            startConnect();
            dt1 = new DataTable();
            String sqlCommand = "SELECT " + select + " FROM " + from;
            if (where.Length > 0) 
            {
                sqlCommand += " WHERE " + where;
            }
            cmd.CommandText = sqlCommand;

            if (arrValues.Count() > 0) 
            {
                foreach (SQLiteParameter value in arrValues) 
                {
                    cmd.Parameters.Add(value);
                }
            }

            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
            return dt1;
        }

        protected DataTable selectQuery(String select, String from, String where, SQLiteParameter[] arrValues, String group_by)
        {
            startConnect();
            dt1 = new DataTable();
            String sqlCommand = "SELECT " + select + " FROM " + from;
            if (where.Length > 0)
            {
                sqlCommand += " WHERE " + where;
            }
            sqlCommand += group_by;
            cmd.CommandText = sqlCommand;

            if (arrValues.Count() > 0)
            {
                foreach (SQLiteParameter value in arrValues)
                {
                    cmd.Parameters.Add(value);
                }
            }

            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
            return dt1;
        }

        public bool existQuery(String from, String where, SQLiteParameter[] arrValues)
        {
            startConnect();
            dt1 = new DataTable();
            String sqlCommand = "SELECT count(*) FROM " + from;
            if (where.Length > 0)
            {
                sqlCommand += " WHERE " + where;
            }
            cmd.CommandText = sqlCommand;

            if (arrValues.Count() > 0)
            {
                foreach (SQLiteParameter value in arrValues)
                {
                    cmd.Parameters.Add(value);
                }
            }
            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
            if (dt1.Rows[0][0].ToString() == "1") 
            {
                return true;
            }
            return false;
        }

        protected bool insertQuery(String table, Hashtable arrCol)
        {
            startConnect();
            dt1 = new DataTable();

            //get columns, values list
            String column = "", value = "";
            List<SQLiteParameter> arrListValues = new List<SQLiteParameter>();
            foreach (DictionaryEntry entry in arrCol)
            {
                column += entry.Key + ",";
                value  += "@" + entry.Key + ",";
                arrListValues.Add(new SQLiteParameter("@" + entry.Key, entry.Value));
            }
            //delete the last comma ',' character
            column = column.Remove(column.Length - 1);
            value = value.Remove(value.Length - 1);

            //get full query
            String sqlCommand = "INSERT INTO " + table + "(" + column + ") VALUES(" + value + ")";

            //append value
            foreach (SQLiteParameter val in arrListValues)
            {
                cmd.Parameters.Add(val);
            }
            
            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
            return true;
        }

        protected void updateQuery(String table, String where, SQLiteParameter[] arrValues, Hashtable arrCol)
        {
            startConnect();
            dt1 = new DataTable();

            //get columns list
            String column = "";
            List<SQLiteParameter> arrListValues = new List<SQLiteParameter>();
            foreach (DictionaryEntry entry in arrCol)
            {
                column += entry.Key + "=@" + entry.Key + ",";
                arrListValues.Add(new SQLiteParameter("@" + entry.Key, entry.Value));
            }
            //delete the last comma ',' character
            column = column.Remove(column.Length - 1);

            //get full query
            String sqlCommand = "UPDATE " + table + " SET " + column + " WHERE " + where;

            //append value
            foreach (SQLiteParameter val in arrListValues)
            {
                cmd.Parameters.Add(val);
            }

            //append value where
            if (arrValues.Count() > 0)
            {
                foreach (SQLiteParameter value2 in arrValues)
                {
                    cmd.Parameters.Add(value2);
                }
            }
            cmd.CommandText = sqlCommand;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
        }

        protected void updateQueryDirectly(String query, SQLiteParameter[] arrValues)
        {
            startConnect();
            dt1 = new DataTable();
            cmd.CommandText = query;
            //append value where
            if (arrValues.Count() > 0)
            {
                foreach (SQLiteParameter value2 in arrValues)
                {
                    cmd.Parameters.Add(value2);
                }
            }
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            stopConnect();
        }
    }
}
