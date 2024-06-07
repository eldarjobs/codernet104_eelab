using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.models;

public class BaseHuman
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    



}


public class students : BaseHuman
{
    public string StudentNo { get; set; }
}

public class Teacher : BaseHuman

{
    
    public string Department { get; set; }
    public string Salary { get; set; }
}
