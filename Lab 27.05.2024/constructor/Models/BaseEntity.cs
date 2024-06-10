//using constructor.Models;
//using Newtonsoft.Json;
//using System.Net;
//using System.Net.Sockets;
//using static System.Net.WebRequestMethods;

//namespace constructor.Models
//{
//    public static class Helper
//    {
//        public static string GetLocalAddress()
//        {

//            var host = Dns.GetHostEntry(Dns.GetHostName());
//            foreach (var ip in host.AddressList)
//            {
//                if (ip.AddressFamily == AddressFamily.InterNetwork)
//                {
//                    return ip.ToString();
//                }
//            }
//            throw new Exception("No network adapters with an IPv4 address in the system!");
//        }
//        public static string GetComputerName()
//        {
//            return Environment.MachineName;
//        }
//        public static async Task<string> GetIpAddress()
//        {
//            var ApiUrl = new Uri("https://api.ipify.org");

//            string IpResonse = GetToAddress(url).Result.Ip;
//            return IpResonse;
//        }
//        private static async Task<IpResponse> GetToAddress(string url)
//        {
//            using HttpResponseMessage response = await new Http.Client.GetAsync(url);

//            response.EnsureSuccessStatusCode();

//            string responseBody = await response.Content.ReadAsStringAsync();
//            IpResponse ipresponse = JsonConvert.DeserializeObject<IpResponse>(responseBody);
//            return ipresponse;
//        }
//    }

//}
//public class IpResponse
//{
//    public string? Ip { get; set; }

//}
//public class BaseEntity
//{
//    public BaseEntity()
//    {
//        this.CreatedDate = DateTime.Now;
//        this.CreatedComputerName = Environment.MachineName;
//        this.CreatedIp = Helper.GetIpAddress();
//        this.CreatedLocalIp = Helper.GetLocalAddress();

//    }

//    public int Id { get; set; }
//    public string CreatedLocalIp { get; set; }
//    public string CreatedIp { get; set; }
//    public string CreatedComputerName { get; set; }
//    public DateTime CreatedDate { get; set; }

//    public string GetToAddress { get; set; }


//    public string? _updatedIp;
//    public string? UpdatedIp
//    {
//        get => _updatedIp;

//        set
//        {
//            _updatedIp = value;
//            if (value != null)
//            {
//                this.UpdatedDate = DateTime.Now;

//            }
//        }
//    }
//    public DateTime? UpdatedDate { get; set; }
//    public bool IsDeleted { get; set; }
//}

//public class Employee : BaseEntity
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public string? Email { get; set; }
//    public string? Phone { get; set; }
//}



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
}


