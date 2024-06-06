namespace paramets
{
    internal class Program
    {
        static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            string metin = "code* academt - yaz-li-mi ?derslerin".Replace("-", "")
                .Replace("*", "").Replace("?", "")
                .Replace("?", "")
                .Replace(".", "")
                .Replace(",", "");

            string[] kelimeler = metin.Split("*").ToString().Split("?");

        }
    }
}
