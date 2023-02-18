using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_LinQ
{
    internal class Program
    {
        /*
         * LinQ là viết tắt của Language Intergrated Query - Ngôn ngữ truy vấn tích hợp
         * Cho phép thực hiện các truy vấn dưới dạng Query (Giống SQL)
         * LinQ có thể được áp dụng thực thi trên các đối tượng để truy cập
         * đến các nguồn dữ liệu như Db, Collection, xml, hay các dạng
         * sequence (tập hợp) nói chung
         * LinQ có cấu trúc khá dễ hiểu và được ghép từ nhiều loại mệnh đề
         * Nó được cài đặt dưới dạng thu viện System.LinQ;
         * LinQ có thể được sử dụng kết hợp với Anonymous nói chung
         * LinQ có ưu điểm là dễ viết, dễ hiểu, dễ sử dụng
         * Nhược điểm của LinQ là tốc độ không thực sự nhanh
         */
        static void Main(string[] args)
        {
            string[] arr = { "Heloo", "ABC", "Xyz", "Xìn chao", "tttt" };

            // LinQ lọc ra những từ có A hoặc a
            var ketqua = from words in arr // Mệnh đề from
                         where words.ToLower().Contains("a") // Mệnh đề where
                         select words; // mệnh đề select
            // Khi mệnh đề where được bỏ qua thì mọi phần tử sẽ được lấy
            // Dùng lambda expression
            var ketqua2 = arr.Where(p => p.ToLower().Contains("a"));
            var ketqua3 = from words in arr // Mệnh đề from
                          where words.ToLower().Contains("a") // Mệnh đề where
                          && words.Length >= 5 // dùng && và where đều được
                          select words;
            // Cú pháp Order by
            var ketqua4 = from words in arr // Mệnh đề from
                          orderby words descending // Sắp xếp giảm dần
                          select words;
            var ketqua5 = arr.OrderBy(p => p).ToList(); // Sắp xếp giảm dần
            // Cú pháp Group by
            List<Nguoi> nguois = new List<Nguoi>() {
                new Nguoi(){Ten="Tốt", Tuoi = 100},
                new Nguoi(){Ten="Xấu", Tuoi = 60},
                new Nguoi(){Ten="Tàn ác", Tuoi = 200},
                new Nguoi(){Ten="Vui tính", Tuoi = 40},
                new Nguoi(){Ten="Vui tính", Tuoi = 150},
                new Nguoi(){Ten="Tàn ác", Tuoi = 30}
            };
            var ketqua6 = from nguoi in nguois
                          group nguoi by nguoi.Ten;
            //foreach (var group in ketqua6)
            //{
            //    Console.WriteLine(group.Key);
            //    Console.WriteLine(group.Count());
            //}
            // Phép group by trả về các group với các thuộc tính tương ứng của group
            // Phép Join
            List<QuaiThu> quaithus = new List<QuaiThu>() {
                new QuaiThu(){Ten="Đẹp", Tuoi = 100},
                new QuaiThu(){Ten="Xấu", Tuoi = 60},
                new QuaiThu(){Ten="Tàn ác", Tuoi = 200},
                new QuaiThu(){Ten="Xấu tính", Tuoi = 40},
                new QuaiThu(){Ten="Dã man", Tuoi = 150},
                new QuaiThu(){Ten="Tàn ác", Tuoi = 30}
            };
            var ketqua7 = from nguoi in nguois
                          join quaithu in quaithus
                          on nguoi.Ten equals quaithu.Ten // Dùng equals thay cho ==
                          select new
                          {
                              name = quaithu.Ten,
                              age = nguoi.Tuoi
                          };
            foreach (var item in ketqua7)
            {
                Console.WriteLine(item.age + "  " + item.name);
            }
            // Với Lambda
            var query = nguois    // your starting point - table in the "from" statement
            .Join(quaithus, // the source table of the inner join
            nguoi => nguoi.Ten,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
            quaithu => quaithu.Ten,   // Select the foreign key (the second part of the "on" clause)
            (nguoi, quaithu) => new { name = nguoi.Ten, age = quaithu.Tuoi });
            foreach (var item in ketqua7)
            {
                Console.WriteLine(item.age + "  " + item.name);
            }
            //Console.WriteLine(string.Join("--", ketqua5));
            // Link tham khảo LinQ: https://www.tutorialsteacher.com/linq

        }
        public class Nguoi
        {
            int tuoi; string ten;
            public Nguoi()
            {
            }
            public Nguoi(int tuoi, string ten)
            {
                this.Tuoi = tuoi;
                this.Ten = ten;
            }
            public int Tuoi { get => tuoi; set => tuoi = value; }
            public string Ten { get => ten; set => ten = value; }
        }
        public class QuaiThu
        {
            int tuoi; string ten;
            public QuaiThu()
            {
            }
            public QuaiThu(int tuoi, string ten)
            {
                this.Tuoi = tuoi;
                this.Ten = ten;
            }
            public int Tuoi { get => tuoi; set => tuoi = value; }
            public string Ten { get => ten; set => ten = value; }
        }
    }
}
