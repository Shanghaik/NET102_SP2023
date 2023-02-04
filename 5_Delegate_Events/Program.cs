using System;
using System.Text;
using System.Threading;

namespace _4_Delegate_Events
{
    /*
     * Events - Sự kiện là các hành động bất kì tác động lên ứng dụng
     * VD: Click chuột, ấn enter, thay đổi dữ liệu,...
     * Trong C# thì event là 1 đối tượng đặc biệt của Delegate, là nơi
     * chứa các phương thức và sẽ được thực thi khi các Sự kiện được
     * sảy ra
     * Đặc điểm của event:
     * Được khai báo trong các lớp hoặc interface
     * Là Abstract hoặc sealed, virtual
     * Được thực thi thông qua delegate
     * --> Cách tạo và sử dụng
     * B1: Định nghĩa delegate cho event
     * B2: Tạo event thông qua delegate
     * B3: Đăng kí dể lắng nghe (hearing) và xử lý event
     * B4: Kích hoạt event thông qua các hành động cụ thể
     */
    // Bước 1: Tạo delegate 
    delegate void UpdateTuoiHandler(int tuoi);
    // Bước 2: Tạo lớp chứa event và tạo event
    class Nguoi
    {
        int tuoi;
        public event UpdateTuoiHandler updateTuoi; // Mặc định là null
        public int Tuoi { 
            get => tuoi; 
            set { 
                tuoi = value;
                if(updateTuoi!= null) // Khi update (set) tuổi => chạy sự kiện
                { // updateTuoi != null là khi Hoạt động của event đã được định nghĩa
                    updateTuoi(tuoi);
                }
            } 
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Nguoi nguoi = new Nguoi();
            nguoi.updateTuoi += Nguoi_updateTuoi;
            // += tab tab => để thực hiện việc định nghĩa cho sự kiện
            nguoi.Tuoi = 15; nguoi.Tuoi = 30;
            Console.WriteLine("Nhập tuổi mới");
            nguoi.Tuoi = Convert.ToInt32(Console.ReadLine());
        }

        private static void Nguoi_updateTuoi(int tuoi)
        {
            Console.WriteLine("Loading.................");
            Thread.Sleep(2000);
            Console.WriteLine("Tuổi của bạn đã được thay đổi, " +
                "tuổi hiện tại là "+ tuoi);
        }
        // Tạo 1 sự kiện cho đối tượng Hocsinh và khởi chạy với nội dung như sau:
        // Khi nhập điểm -> Điểm < 5 thì in ra trạng thái là tạch => set
        // Khi lấy điểm -> ĐƯa ra dòng thông tin là điểm đã được lấy => get
    }
}
