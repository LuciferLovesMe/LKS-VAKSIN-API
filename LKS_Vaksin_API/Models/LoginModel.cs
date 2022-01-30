using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Vaksin_API.Models
{
    public class LoginModel
    {
        public int id { set; get; }
        public string nama { set; get; }
        public string nik { set; get; }
        public string noHp { set; get; }
        public string tempat_lahir { set; get; }
        public string tanggal_lahir { set; get; }
    }
}