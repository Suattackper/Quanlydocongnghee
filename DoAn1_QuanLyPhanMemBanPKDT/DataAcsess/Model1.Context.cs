﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLPKDTEntities2 : DbContext
    {
        public QLPKDTEntities2()
            : base("name=QLPKDTEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<KhoHang> KhoHang { get; set; }
        public virtual DbSet<NhaCC> NhaCC { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
    }
}
