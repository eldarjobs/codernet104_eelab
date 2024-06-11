namespace Constructor_.Models;
using System.Net;
using System.Net.Sockets;

public static class Helper
{
    public static string GetComputerName() => Environment.MachineName;

    public static string GetLocalIp()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }


    public static string GetIp()
    {
        var apiUrl = new Uri("http://ipinfo.io/ip");

        string ipResonse = GetToAddress(apiUrl.ToString()).GetAwaiter().GetResult();

        return ipResonse;
    }

    private static async Task<string> GetToAddress(string url)
    {

        using HttpResponseMessage response = await new HttpClient().GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }


}

public class BaseEntity
{
    public BaseEntity(string currentUserFullName) : this()
    {
    }


    public BaseEntity()
    {
        this.CreatedDate = DateTime.UtcNow;
        this.CreatedComputerName = Helper.GetComputerName();
        this.CreatedIp = Helper.GetIp();
        this.CreatedLocalIp = Helper.GetLocalIp();
    }

    public int Id { get; set; }
    public string CreatedLocalIp { get; set; } = null!;
    public string CreatedIp { get; set; } = null!;
    public string CreatedComputerName { get; set; } = null!;
    public DateTime CreatedDate { get; set; }

    private string? _updatedIp;  // nullable
                                 //private Nullable<int> _updatedIp;  // nullable
    public string? UpdatedIp
    {
        get => _updatedIp;
        set
        {
            _updatedIp = value;
            if (value != null)
            {
                this.UpdatedDate = DateTime.UtcNow;
                #region Description
                // bilgisayarın koordinatlı evrensel zamanını alır.
                /*

                    Saat dili bağımsızdır.
                    Dayly light saving time (DST) uygulamaları ile ilgili sorunlar olabilir.
                    Veri tabanı loglama işlemlerinde kullanılabilir. zaman damgası gerektiren işlemler için UTC kullanmak daha iyidir.
                 */
            }
            #endregion
        }
    }

    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; }
}


public class Employee : BaseEntity
{
    public Employee() : base("Current User") { }
    public Employee(string firstName)
    {
        this.FirstName = firstName;
    }

    public Employee(string firstName, string lastName) : this(firstName)
    {
        //this.FirstName = firstName;
        this.LastName = lastName;
    }

    public Employee(string firstName, string lastName, string email) : this(firstName, lastName)
    {
        //this.FirstName = firstName;
        //this.LastName = lastName;
        this.Email = email;
    }

    public Employee(string firstName, string lastName, string email, string phone) : this(firstName, lastName, email)
    {
        //this.FirstName = firstName;
        //this.LastName = lastName;
        //this.Email = email;
        this.Phone = phone;
    }



    public string FirstName { get; set; } = null!; // required
    public string LastName { get; set; } = null!;
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

/*
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace constructor.Models
{
    public static class Helper
    { 
        public static string GetLocalAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static string GetComputerName()
        {
            return Environment.MachineName;
        }

        public static async Task<string> GetIpAddressAsync()
        {
            using var client = new HttpClient();
            var apiUrl = new Uri("https://api.ipify.org");
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            IpResponse ipResponse = JsonConvert.DeserializeObject<IpResponse>(responseBody);
            return ipResponse.Ip;
        }
    }

    public class IpResponse
    {
        public string? Ip { get; set; }
    }

    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedLocalIp { get; set; }
        public string CreatedIp { get; set; }
        public string CreatedComputerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Constructor
        public BaseEntity()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedComputerName = Helper.GetComputerName();
            this.CreatedLocalIp = Helper.GetLocalAddress();
            this.CreatedIp = "Not available"; // Initialize with a default value
        }

        // Method to initialize CreatedIp asynchronously
        public async Task InitializeCreatedIpAsync()
        {
            this.CreatedIp = await Helper.GetIpAddressAsync();
        }

        // Method to print BaseEntity details to the console
        public void PrintDetails()
        {
            Console.WriteLine("BaseEntity Details:");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CreatedLocalIp: {CreatedLocalIp}");
            Console.WriteLine($"CreatedIp: {CreatedIp}");
            Console.WriteLine($"CreatedComputerName: {CreatedComputerName}");
            Console.WriteLine($"CreatedDate: {CreatedDate}");
            Console.WriteLine($"UpdatedDate: {UpdatedDate}");
            Console.WriteLine($"IsDeleted: {IsDeleted}");
        }
    }

    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        // Constructor
        public Employee()
        {
            // You can initialize additional properties here if needed
        }
    }
}*/


