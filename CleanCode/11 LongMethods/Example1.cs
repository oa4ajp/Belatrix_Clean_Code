using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CleanCode._11_LongMethods;

namespace FooFoo
{
    public partial class Download : System.Web.UI.Page
    {
        private CsvService _csvService;

        protected void Page_Load(object sender, EventArgs e)
        {
            _csvService = new CsvService();

            var memoryStream = _csvService.CreateMemoryFile();

            byte[] byteArray = memoryStream.ToArray();
            memoryStream.Flush();
            memoryStream.Close();

            ReponseClear();
            ReponseCache();
            ResponseWriteContent(byteArray);
        }

        private void ReponseClear()
        {
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Cookies.Clear();
        }

        private void ReponseCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.CacheControl = "private";
        }

        private void ResponseWriteContent(byte[] byteArray)
        {
            Response.Charset = System.Text.UTF8Encoding.UTF8.WebName;
            Response.ContentEncoding = System.Text.UTF8Encoding.UTF8;
            Response.ContentType = "text/comma-separated-values";
            Response.AddHeader("Content-Disposition", "attachment; filename=FooFoo.csv");
            Response.AddHeader("Content-Length", byteArray.Length.ToString());
            Response.BinaryWrite(byteArray);
        }

    }

}