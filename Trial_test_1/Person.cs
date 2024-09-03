using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_test_1
{
    internal class Person
    {
        #region bien
        private string name;
        //private int gioiTinh;

        //private string gioiTinh; // gender
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string email;
        public Gender gender;

        #endregion

        #region get/set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }*/
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
      
        public DateTime NgaySinh
        {
            get
            { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        } 
        public string DiaChi 
        { 
            get { return  diaChi; }
            set { diaChi = value; }
        }
        public string Email
        {
            get{ return email; }
            set { email = value; }
        }
        #endregion
        #region constructor
        public Person()
        {

        }

        public Person (string name, string gioiTinh, DateTime ngaySinh, string diaChi, string email)
        {
            this.name = name;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.email = email;
            
        }
        #endregion

        public virtual void PutInfo()
        {
            Console.WriteLine("Xin mời nhập đầy đủ thông tin dưới đây");
            Console.WriteLine("Nhập tên của bạn : ");
            this.name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(this.name))
            {
                Console.WriteLine("Tên không được để trống, hãy ghi lại lần nữa");
                this.name = Console.ReadLine();
            }
            
            Console.WriteLine("Nhập giới tính vào chỗ trống theo format M-F-NB ");
            this.gioiTinh = Console.ReadLine();

                if (this.gioiTinh == "M")
                {
                    gender = Gender.Male;
                    Console.WriteLine("nam");
                }
                else if (this.gioiTinh == "F")
                {
                    gender = Gender.Female;
                    Console.WriteLine("nữ");
                }
                else
                {
                    gender = Gender.NonBinary;
                }
 
            
            // Console.WriteLine("1. Nam - 2 Nữ");
            // this.gioiTinh = int.Parse(Console.ReadLine());
            /*this.gioiTinh = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(this.gioiTinh))
            {
                Console.WriteLine("Giới tính không được để trống, hãy ghi lại lần nữa");
                this.gioiTinh = Console.ReadLine();
            }*/
            /*switch (this.gioiTinh)
            {
                case 1:
                    Console.WriteLine("Nam");
                    break;
                case 2:
                    Console.WriteLine("Nữ");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }*/

            Console.WriteLine("Nhập ngày tháng năm sinh theo dinh dang sau : dd/MM/yyyy");
            // this.ngaySinh = Convert.ToDateTime(Console.ReadLine());
            string dateInput = Console.ReadLine();
            ngaySinh = ConvertToDate(dateInput);

            DateTime dt = DateTime.ParseExact(ngaySinh.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Date of birth : " + s);

            // Console.WriteLine("Nhap ngay sinh thanh cong " + ngaySinh.ToShortDateString());
            Console.WriteLine("Nhập địa chỉ : ");

            this.diaChi = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(this.diaChi))
            {
                Console.WriteLine("Địa chỉ không được để trống, hãy ghi lại lần nữa");
                this.diaChi = Console.ReadLine();
            }


            bool checkEmail;
            bool checkBlank;
            while (true) 
            {
                Console.WriteLine("Nhập địa chỉ email : ");
                email = Convert.ToString(Console.ReadLine());
                checkEmail = email.Contains("@");  // check @
                checkBlank = string.IsNullOrWhiteSpace(email); // check space
                int stringLength = email.Length; // check length
                if (string.IsNullOrEmpty(this.email) && !checkEmail && !checkEmail) 
                {
                    Console.WriteLine("Không được để thiếu @ và bỏ trống");
                    if (stringLength < 18)
                    {
                        Console.WriteLine("Độ dài của email không đủ");
                    }
                    
                } else
                {
                    Console.WriteLine("Nhập thành công");
                    Console.WriteLine("email của bạn là : {0}", email);
                    break;
                }
            }

        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   gioiTinh == person.gioiTinh;
        }
        public DateTime ConvertToDate(string dateInput)
        {
            string[] format = { "dd/MM/yyyy" };

            return DateTime.ParseExact(dateInput, format, null, System.Globalization.DateTimeStyles.None);
        }
       /* public static bool IsValidDate (string date)
        {
            DateTime tempObject;
            return DateTime.TryParse(date, out tempObject);
        }*/
        public virtual void ShowInfo()
        {
            Console.WriteLine("Tên của bạn là : " + this.name);
            Console.WriteLine("Giới tính bạn đã chọn là " + this.gioiTinh);
            Console.WriteLine("Ngay sinh của bạn là : " + this.ngaySinh);
            Console.WriteLine("đia chỉ của bạn là " + this.diaChi);
            Console.WriteLine("email của bạn là " + this.email);

        }

        public override string ToString()
        {
            return this.name + "\t" + this.gioiTinh + "\t" + this.ngaySinh + "\t" + this.diaChi + "\t" + this.email;
        }
    }

    enum Gender
    {
        Male,
        Female,
        NonBinary
    }
}
