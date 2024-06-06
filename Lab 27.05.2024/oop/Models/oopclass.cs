
namespace OOP.Class.Models
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public int age { get; set; }

    }

    /*
    public              -> ayni sinif icerisinde tum elemanlara erisilebilir
    private             -> ayni sinif icerisinde erisilemez
    protected           -> ayni sinif icerisinde erisilebilir
    internal            -> ayni proje icerisinde erisilebilir
    protected internal  -> ayni proje icerisinde erisilebilir
    private protected   -> 
    */
}
