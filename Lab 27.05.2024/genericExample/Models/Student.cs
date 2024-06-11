using genericExample.Models;

public class Student : IEntity
{

    private static int _id;
    public Student()
    {
        Id = _id;
        _id++;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

