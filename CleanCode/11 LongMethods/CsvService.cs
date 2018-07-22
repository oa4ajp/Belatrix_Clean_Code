using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode._11_LongMethods
{
    public class CsvService
    {
        private CsvDataService _csvDataService;

        public CsvService()
        {
            _csvDataService = new CsvDataService();
        }

        public MemoryStream CreateMemoryFile()
        {
            var returnStream = new MemoryStream();

            try
            {
                //Create a streamwriter to write to the memory stream
                var streamWriter = new StreamWriter(returnStream);
                var dataTable = _csvDataService.GetDataTable();

                WriteColumns(streamWriter, dataTable);
                streamWriter.WriteLine();
                WriteRows(streamWriter, dataTable);

                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return returnStream;
        }

        private void WriteColumns(StreamWriter streamWriter, DataTable dataTable)
        {
            int iColCount = dataTable.Columns.Count;

            for (int i = 0; i < iColCount; i++)
            {
                streamWriter.Write(dataTable.Columns[i]);
                if (i < iColCount - 1)
                {
                    streamWriter.Write(",");
                }
            }
        }

        private void WriteRows(StreamWriter streamWriter, DataTable dataTable)
        {
            int iColCount = dataTable.Columns.Count;

            foreach (DataRow dr in dataTable.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string str = String.Format("\"{0:c}\"", dr[i].ToString()).Replace("\r\n", " ");
                        streamWriter.Write(str);
                    }
                    else
                    {
                        streamWriter.Write("");
                    }

                    if (i < iColCount - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.WriteLine();
            }
        }
    }
}
