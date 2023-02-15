using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public int StaffId { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public string Role { get; set; }
    }
}