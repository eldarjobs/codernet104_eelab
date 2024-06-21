using expressions.Models;
using Microsoft.VisualBasic;
using System.Linq;
using System.Linq.Expressions;
#region First Example   

Expression<Func<int, int>> square = x => x * x;
var result = square.Compile();

Console.WriteLine(result(5));


#endregion

#region Second Example

Expression<Func<int, int, bool>> ISGreater = (n1, n2) => n1 > n2;

Func<int, int, bool> IsgreaterFunc = ISGreater.Compile();

Console.WriteLine(IsgreaterFunc(10, 5));
Console.WriteLine(IsgreaterFunc(5, 10));

#endregion

#region Third Example
var employees = new List<Employee>
{

new Employee { FirstName = "John", LastName = "JAck", Age = 25 },
new Employee { FirstName = "Jane", LastName = "Doe", Age = 30 },
new Employee { FirstName = "Jack", LastName = "Jony", Age = 35 },
new Employee { FirstName = "Joe", LastName = "Doe", Age = 45 },
new Employee { FirstName = "Judy", LastName = "Bakter", Age = 50 },
new Employee { FirstName = "Jen", LastName = "Brow", Age = 55 },
};


Expression<Func<Employee, bool>> filter = e => e.Age >= 18;

//if (filter.Body is BinaryExpression binary)
//{
//    Console.WriteLine(binary);
//    Console.WriteLine(binary.Left);
//    Console.WriteLine(binary.Right);
//    Console.WriteLine(binary.NodeType);
//}


//var adultEmployees = employees.Where(x => filter.Compile()(x)).ToList();
//adultEmployees.ForEach(x => Console.WriteLine(x));


List<string> clear = new List<string>() { "lorem?", "ipsum{", "dolor.", "sit,", "jbs^" };
clear.ForEach(text => Console.WriteLine(text));

Expression<Func<string, string>> clearExpression = e => e.ToLower().Replace("?", "").Replace("{", "").Replace(".", "").Replace(",", "").Replace("^", "");

var cleartext = clearExpression.Compile();

var filteredTexts = clear.Select(cleartext).ToList();

filteredTexts.ForEach(text => Console.WriteLine(text));

#endregion

#region Fourth Example

#endregion

#region Fifth Example

#endregion