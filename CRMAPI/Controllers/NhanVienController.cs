using CRMAPI.DAO;
using CRMAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CRMAPI.Controllers
{
    public class NhanVienController : ApiController
    {


        // GET: NhanVien
        public IEnumerable<NHANVIEN> Get()
        {
            return new NhanVienDAO().GetAll();
        }

        // GET api/NhanVien/5
        public NHANVIEN Get(Guid Id)
        {
            return new NhanVienDAO().GetById(Id);
        }

        // POST api/NhanVien
        public void Post([FromBody] NHANVIEN nHANVIEN)
        {
            new NhanVienDAO().Create(nHANVIEN);
        }

        // PUT api/NhanVien/5
        public void Put(Guid Id, [FromBody] NHANVIEN nHANVIEN)
        {
            nHANVIEN.NHANVIEN_Id = Id;
            new NhanVienDAO().Edit(nHANVIEN);
        }

        // DELETE api/NhanVien/5
        public void Delete(Guid Id)
        {
            new NhanVienDAO().Delete(Id);
        }
    }
}