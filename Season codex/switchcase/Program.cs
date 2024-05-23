namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("enter the season");
            string season = Console.ReadLine();

            string sea = season switch
            {
                "winter" => "Qis",

                "summer" => "yay",

                "spring" => "yaz",

                "authum" => "payiz"
            };
        
            Console.WriteLine(sea);


            string season2 = Console.ReadLine();

            switch (season2)
            {
                case "winter":
                    Console.WriteLine("Fesil Qis");
                    break;
                case "summer":
                    Console.WriteLine("Fesil- Yay");
                    break;
                case "spring":
                    Console.WriteLine("Fesil - Yaz");
                    break;
                case "autumn":
                    Console.WriteLine("Fesil -Payiz");
                    break;
                default:
                    Console.WriteLine("Bele fesil yoxdu");
                    break;


            }


        }
    }
}
