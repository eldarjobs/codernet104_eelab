using example.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

var employees = new List<Employee>
{

new Employee { FirstName = "John", LastName = "JAck", Age = 25 },
new Employee { FirstName = "Jane", LastName = "Doe", Age = 30 },
new Employee { FirstName = "Jack", LastName = "Jony", Age = 35 },
new Employee { FirstName = "Joe", LastName = "Doe", Age = 45 },
new Employee { FirstName = "Judy", LastName = "Bakter", Age = 50 },
new Employee { FirstName = "Jen", LastName = "Brow", Age = 55 },
};

var employeeDtos = new List<EmployeeDto>
{

new EmployeeDto { FirstName = "Ahmed", LastName = "Ghazal", Age = 25 },
new EmployeeDto { FirstName = "mohamed", LastName = "Saied", Age = 30 },
new EmployeeDto { FirstName = "Len", LastName = "Khan", Age = 35 },
new EmployeeDto { FirstName = "Ben", LastName = "Yahya", Age = 45 },
new EmployeeDto { FirstName = "Queen", LastName = "Pen", Age = 50 },
new EmployeeDto { FirstName = "Peter", LastName = "Brow", Age = 55 },
};

Expression<Func<Employee, Employee>> validateEmployee = e => new()
{
    FirstName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(e.FirstName.ToLower()),
    LastName = e.LastName.ToUpper().Trim(),
    Email = $"{e.FirstName}.{e.LastName}@example.com".ToLower().Replace(" ", ""),
};

employees.AsQueryable()
    .Select(validateEmployee)
    .ToList().ForEach(e => Console.WriteLine($"FirstName:{e.FirstName.PadRight(10)} LastName:{e.LastName.PadRight(10)} Email:{e.Email}"));

Expression<Func<Source, Destination>> Map<Source, Destination>(Expression<Func<Source, Destination>> expression)
{
    var sourceParametr = Expression.Parameter(typeof(Source), "source");
    var bindings = new List<MemberBinding>();

    foreach (PropertyInfo property in typeof(Source).GetProperties())
    {
        var sourceProperty = typeof(Source).GetProperty(property.Name);
        if (sourceProperty == null)
        {
            var sourcepropertyexpression = Expression.Property(sourceParametr, property.Name);
            var propertyBinding = Expression.Bind(property, sourcepropertyexpression);
            bindings.Add(propertyBinding);
        }
    }

    var body = Expression.MemberInit(Expression.New(typeof(Destination)), bindings);
    return Expression.Lambda<Func<Source, Destination>>(body, sourceParametr);
}




public class EmployeeDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}
