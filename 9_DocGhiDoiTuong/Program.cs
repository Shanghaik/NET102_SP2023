using System;
using System.Collections.Generic;

namespace _9_DocGhiDoiTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SanPham> sanPhams= new List<SanPham>() {
                new SanPham(){Id = Guid.NewGuid(), TenSP = "Co hats", GiaSp = 10000, NhaCungCap = "Coca"},
                new SanPham(){Id = Guid.NewGuid(), TenSP = "Pepsi", GiaSp = 10000, NhaCungCap = "PP"},
                new SanPham(){Id = Guid.NewGuid(), TenSP = "Fanta", GiaSp = 10000, NhaCungCap = "FF"},
                new SanPham(){Id = Guid.NewGuid(), TenSP = "7Up", GiaSp = 10000, NhaCungCap = "7Up"},
                new SanPham(){Id = Guid.NewGuid(), TenSP = "Sting", GiaSp = 15000, NhaCungCap = "Sting"}
            };
            //DocGhiFileTxt docGhiFileTxt = new DocGhiFileTxt();
            ////docGhiFileTxt.GhiVaoFileText("Sanpham.txt", sanPhams);
            //List<SanPham> sps = docGhiFileTxt.DocTuFileText("Sanpham.txt");
            //foreach (var item in sps)
            //{
            //    item.InThongTin();
            //}
            // Làm với file XML
            //DocGhiFileXml docGhiFileXml = new DocGhiFileXml();
            ////docGhiFileXml.GhiVaoFileXml<SanPham>("Sanpham.xml", sanPhams);
            //List<SanPham> sps = docGhiFileXml.DocTuFileXml<SanPham>("Sanpham.xml");
            //foreach (var item in sps)
            //{
            //    item.InThongTin();
            //}
            DocGhiFileBin.GhiVaoFileBin("Sanpham.bin", sanPhams);
            List<SanPham> list = DocGhiFileBin.DocTuFileBin<SanPham>("Sanpham.bin");
            foreach (var item in list)
            {
                item.InThongTin();
            }
        }
    }
}
