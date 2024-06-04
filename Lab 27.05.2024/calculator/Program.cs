namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sahe = 0;
            AreaCalc(5, out sahe);
            Console.WriteLine($"Triangle Area is {sahe}");
            AreaCalc(15, 2, out sahe);
            Console.WriteLine($"Circle Area is  {sahe}");

            Console.ReadKey();

            
        }

        public static void AreaCalc(int teref, int teref2, out double sahe)
        {
           sahe = teref * teref2/2 ;   
        
        }
        public static void AreaCalc(int radius,out double sahe)
        {
            sahe = 3 * radius * radius ;

        }

        

    }
    
}
