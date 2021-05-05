using CRMAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace CRMAPI.DAO
{
    public class NhanVienDAO
    {
        Database db = null;
        public NhanVienDAO()
        {
            db = new Database();
            db.Configuration.ProxyCreationEnabled = false;

        }

        public IEnumerable<NHANVIEN> GetAll ()
        {
            IQueryable<NHANVIEN> items = db.NHANVIENs;
            return items;
        }
        
        public NHANVIEN GetById(Guid Id)
        {
            var model = db.NHANVIENs.Find(Id);
            return model;
        }

        public NHANVIEN GetByCode(string NHANVIEN_Code)
        {
            return db.NHANVIENs.SingleOrDefault(x => x.NHANVIEN_Code == NHANVIEN_Code);
        }
        public string GetCode()
        {
            string Code = "NV";
            bool Check = true;
            var num = db.NHANVIENs.Count();
            while (Check)
            {
                if (num == 0)
                {
                    Code += "001";
                }
                else if (num > 0 && num < 9)
                {
                    Code += "00" + (num + 1).ToString();
                }
                else if (num >= 9 && num < 99)
                {
                    Code += "0" + (num + 1).ToString();
                }
                else if (num >= 99 && num < 999)
                {
                    Code += (num + 1).ToString();
                }
                if (GetByCode(Code) == null)
                {
                    Check = false;
                }
                else
                {
                    num += 1;
                }
            }
            return Code;
        }

        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi + "hn");

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        public bool Create(NHANVIEN nHANVIEN)
        {
            try
            {
                nHANVIEN.NHANVIEN_Code = GetCode();
                nHANVIEN.NHANVIEN_Pass = GetMD5(nHANVIEN.NHANVIEN_Pass);
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(NHANVIEN nHANVIEN)
        {
            try
            {
                var data = db.NHANVIENs.Find(nHANVIEN.NHANVIEN_Id);
                data.NHANVIEN_HoTen = nHANVIEN.NHANVIEN_HoTen;
                data.NHANVIEN_NgaySinh = nHANVIEN.NHANVIEN_NgaySinh;
                data.NHANVIEN_Moblie = nHANVIEN.NHANVIEN_Moblie;
                data.NHANVIEN_Email = nHANVIEN.NHANVIEN_Email;
                data.NHANVIEN_DiaChi = nHANVIEN.NHANVIEN_DiaChi;
                data.NHANVIEN_GhiChu = nHANVIEN.NHANVIEN_GhiChu;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid Id)
        {
            try
            {
                var article = db.NHANVIENs.Find(Id);
                db.NHANVIENs.Remove(article);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}