using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_test_1
{
    internal class StaffFunction
    {
        private List<Staff> listStaffs = null;

        public StaffFunction() 
        {
            listStaffs = new List<Staff>();
           
        }
        
        public void Display()
        {
            
            Console.WriteLine("1. Nhập vào thông tin đầy đủ của nhân viên");
            Console.WriteLine("2. Hiển thị thông tin nhân viên");
            Console.WriteLine("3. Hiện thị thông tin nhân viên lương cao và thấp nhất");
            Console.WriteLine("4. Tìm kiếm nhân viên theo mã nhân viên");
            Console.WriteLine("5. Thoát ");
        }

        public void InsertStaff()
        {
            Staff staff = new Staff();
            staff.PutInfo();
            listStaffs.Add(staff);
            listStaffs.Max();
        }

        public void DisplayStaff(List<Staff> listStaffs)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 7} {4, 8} {5, 5} {6, 5} {7, 10} ",
                  "ID", "Name", "Gender", "Date of Birth", "Address", "Email", "Salary", "Work In Year");

            // hien thi danh sach nhan vien
            if (listStaffs != null && listStaffs.Count > 0)
            {
                foreach (Staff st in listStaffs)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 6} {5, 5} {6, 5} {7, 10}",
                                      st.ID, st.Name, st.GioiTinh, st.NgaySinh.ToShortDateString(), st.DiaChi, st.Email, st.Salary,
                                      st.WorkInYear);
                }

            }
        }

        public List<Staff> GetLists() // truyền lên thằng displays staff
        {
            return listStaffs;
        }

        // find by ID
        public Staff FindStaffById(long id)
        {
            Staff staffId = null;

            if (listStaffs != null && listStaffs.Count > 0)
            {
                foreach (Staff staff in  listStaffs)
                {
                    if (staff.ID == id)
                    {
                        staff.ID = id;                  
                    }
                }
            }
            return staffId;
        }

        // sorting by salary
        public void SortBySalaryStaff()
        {
            listStaffs.Sort(delegate (Staff st1, Staff st2)
            {
                return st1.SalaryWorker(st1.Salary, st1.WorkInYear).CompareTo(st2.SalaryWorker(st2.Salary,st2.WorkInYear));
            });
        }

        public void findMaxSalary()
        {
            SortBySalaryStaff();
            
        }
    }
}
