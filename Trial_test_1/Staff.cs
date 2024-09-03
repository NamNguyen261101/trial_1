using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trial_test_1
{
    internal class Staff : Person
    {
        #region khởi tạo biến
        // private static long Count;
        private static long id;
        private double salary;
        private int workInYear;
        #endregion

        #region get/set
        public long ID 
        { 
            get { return id; } 
            set { id = value; }
        }

        public double Salary 
        { 
            get { return salary; } 
            set { salary = value; } 
        }

        public int WorkInYear
        {
            get { return workInYear; }
            set { workInYear = value; }
        }
        #endregion
        #region constructor
        public Staff() 
        {

        }

        public static long generateId()
        {
            return id++;
        }
        public Staff(double salary, int workInYear) : base()
        {
            // Count++;
            // this.id = Count;
            this.salary = salary;
            this.workInYear = workInYear;
           
        }


        #endregion
        #region Tính Lương chính thức
        // Quest 2 - tính lương nhân viên cách thực tế
        public double SalaryWorker(double salary, int workInYear)
        {
            return salary* 2150000 + workInYear *0.2 ;
        }
        #endregion

        #region override PutInfo - ShowInfo
        public override void PutInfo() // virtual 
        {
            generateId();
            base.PutInfo();
            Console.WriteLine("Nhập số năm đã làm việc : ");
            this.workInYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lương tối thiểu ");
            this.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("abc");
            Console.WriteLine("id " + id);
        }

        public override void ShowInfo()
        {
            Console.WriteLine("ID của bạn là " + id);
            base.ShowInfo();
            Console.WriteLine("Số năm bạn đã làm việc là :" + this.workInYear);
            Console.WriteLine("Lương cơ bản là : " + this.salary);
        }
        #endregion
    }
}
