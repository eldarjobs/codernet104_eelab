using employee.Models;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HourlyEmployee employee = new HourlyEmployee();

            employee.Name = "Test";
            employee.Surname = "Test";
            employee.Age = 20;
            employee.Hours = 10;
            employee.Rate = 10;


            SalariedEmployee employee2 = new SalariedEmployee();
            
            employee2.Name = "Test";
            employee2.Surname = "Test";
            employee2.Age = 20;
            employee2.Salary = 1000;


            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Salary monthly: {employee.CalculateSalary()}");
            employee.ShowDetails();
            Console.WriteLine(new String('-', 30));
            
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Salary monthly: {employee2.CalculateSalary()}");
            employee2.ShowDetails();
            Console.WriteLine(new String('-', 30));



        }
    }
}





//1.Employee Interface'i yaranacaq.

//1.1 Özəllikləri(Properties):
//Id = int type, Employee object'in Idsi saxlanılacaq
//Name - string type, Employee object'in adı saxlanılacaq
//Surname - string type, Employee object'in soyadı saxlanılacaq
//Age - int type, Employee object'in yaşı saxlanılacaq

//NOT: Id bizim tərəfimizdən daxil edilməməli, hər dəfə Employee'dan miras alan class'ın instace'ı alınan zaman avtomatik olaraq özü arxa tərəfdə Id-ə mənimsədilməlidir. Lakin bilməli olduğumuz məqam Id hər bir object üçün unique olmalıdır. Bu da deməkdir ki Id property readonly olmalıdır. Və static olaraq artan bir counter field'a ehtiyyacımız olacaq.

//1.2 Davranış(Methods):

// double CalculateSalary() -Hər bir object üçün aldığı maaşı hesablamalıdır.
// void DisplayDetails() - Hər bir object'in haqqındaki məlumatları ekrana çıxarılmalıdır.

//2. Employee Class'dan miras alan 2 class mövcud olmalıdır. HourlyEmployee və SalariedEmployee

//3.1 HourlyEmployee

//3.2 Özəllikləri:
//HourlyRate - dobule type, HourlyEmployee object'in saatlıq qazancı saxlanılacaq.
//HoursWorked - double type, HourlyEMployee object'in aylıq çalışdığı saat saxlanılacaq.

//3.3 Davranış:

//double CalculateSalary() -implement edilməlidir və method HourlyEmployee'un saatlıq qazancını * aylıq işlədiyi saata vurub geri qaytarmalıdır.

//void DisplayDetails() - implement edilməlidir və method HourlyEmployee'un haqqındaki məlumatları ekrana çıxarmalıdır.

//4.1 SalariedEmployee

//4.2 Özəllikləri:

//MonthlySalary - double type, SalariedEmployee object'in aylıq qazancını saxlayacaq.

//4.3 Davranışı:

//double CalculateSalary() -implement edilməlidir və method SalariedEmployee'un aylıq qazancını geri qaytarmalıdır.

//void DisplayDetails() - implement edilməlidir və method SalariedEmployee'un haqqındaki məlumatları ekrana çıxarmalıdır.

//5. Program.cs daxilində hər iki class'a uyğun object alınmalı və hər bir method çalıştırılmalıdır.
