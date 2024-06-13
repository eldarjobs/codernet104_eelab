using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ENUM.Models
{
    public enum Departments
    {
        HR,
        IT,
        Finance,
        Sales,
        Marketing

    }
    public enum Status
    {
        None,
        Active,
        Inactive,
        Blocked,
        Pending,
        Rejected,
        Cancelled,
    }



    internal class employee
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Departments Department { get; set; } = Departments.HR;
        public Color SacRengi { get; set; }
        public Status Status { get; set; }

    }
}

public enum Sehirler
{
    Istanbul = 1,
    Ankara = 2,
    Izmir = 3,
    Adana = 4,
    Mersin = 5,
    Denizli = 6

        
}

