﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CleanCode._11_LongMethods
{
    public class CsvDataService
    {
        public DataTable GetDataTable()
        {
            string strConn = ConfigurationManager.ConnectionStrings["FooFooConnectionString"].ToString();
            var conn = new SqlConnection(strConn);
            var da = new SqlDataAdapter("SELECT * FROM [FooFoo] ORDER BY id ASC", conn);
            var ds = new DataSet();
            da.Fill(ds, "FooFoo");
            var dataTable = ds.Tables["FooFoo"];

            return dataTable;
        }        
    }
}
