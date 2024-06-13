using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace news.Models
{
     
    public record Employee(string FirstName, string LastName, string Email, string Phone);

}

//record -> immutable
