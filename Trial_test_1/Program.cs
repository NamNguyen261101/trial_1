using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StaffFunction staffFunction = new StaffFunction();
            while (true)
            {
                staffFunction.Display();
                int choice;
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Enter your staff : ");
                        staffFunction.InsertStaff();
                    break;
                    case 2:
                        staffFunction.DisplayStaff(staffFunction.GetLists());
                    break;
                    case 3:

                    break;
                    case 4:
                        Console.WriteLine("Nhập mã nhân viên cần tìm kiếm theo ID là : " );
                        int f = int.Parse(Console.ReadLine());
                        staffFunction.FindStaffById(f);
                    break;
                    case 5:
                        Console.WriteLine("Exit !!!");
                    break;

                    default:

                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
