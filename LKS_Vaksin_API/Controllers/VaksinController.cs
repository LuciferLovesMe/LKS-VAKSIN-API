using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Vaksin_API.Models;

namespace LKS_Vaksin_API.Controllers
{
    public class VaksinController : ApiController
    {
        SqlConnection connection = new SqlConnection(Connection.conn);

        [HttpPost]
        public DataTable data([FromBody]LoginModel model)
        {
            SqlDataAdapter command = new SqlDataAdapter("select * from vaksinasi join detail_vaksinasi on vaksinasi.id = detail_vaksinasi.id_vaksinasi join jenis_vaksin on detail_vaksinasi.id_jenis_vaksin = jenis_vaksin.id join admin on detail_vaksinasi.id_dokter = admin.id where vaksinasi.nik = '" + model.nik + "'", connection) ;
            DataTable table = new DataTable();
            command.Fill(table);
            return table;
        }
    }
}
