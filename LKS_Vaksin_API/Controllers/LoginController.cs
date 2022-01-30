using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Vaksin_API.Models;

namespace LKS_Vaksin_API.Controllers
{
    public class LoginController : ApiController
    {
        LKS_VaksinEntities row = new LKS_VaksinEntities();
        
        [HttpPost]
        public IHttpActionResult result ([FromBody] LoginModel model)
        {
            if(model != null)
            {
                string sql = "select * from warga where nik = '" + model.nik + "' and noHp = '" + model.noHp + "'";
                var user = row.wargas.SqlQuery(sql).FirstOrDefault();
                if(user != null)
                {
                    LoginModel u = new LoginModel();
                    u.id = Convert.ToInt32(user.id_user);
                    u.nama = user.nama.ToString();
                    u.nik = user.nik.ToString();
                    u.noHp = user.noHp.ToString();
                    u.tanggal_lahir = Convert.ToString(user.tanggal_lahir);
                    u.tempat_lahir = user.tempat_lahir.ToString();
                    return Ok(u);
                }

                return Ok(user);
            }
            else
            {
                return null;
            }
        }
    }
}
