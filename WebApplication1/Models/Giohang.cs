using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Giohang
    {
        DataQLBanDTDDDataContext data = new DataQLBanDTDDDataContext();
        public int iMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sAnhbia { get; set; }
        public Double dDongia { get; set; }
        public int iSoluong { get; set; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        public Giohang(int MaSP)
        {
            iMaSP = MaSP;
            SANPHAM sp = data.SANPHAMs.Single(n => n.MaSP == iMaSP);
            sTenSP = sp.TenSP;
            sAnhbia = sp.Anhbia;
            dDongia = double.Parse(sp.Giaban.ToString());
            iSoluong = 1;
        }
    }
}