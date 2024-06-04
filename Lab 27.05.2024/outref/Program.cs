namespace outref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator(3, 2, out float bolme, out int vurma, out int toplama, out int cixma, out int modm);
            
            Console.WriteLine($"""
            
            toplama = {toplama} 
            cixma = {cixma} 
            vurma = {vurma} 
            bolme = {bolme}
            modm = {modm}
            """); 

           
            
        }
        static int Hesablama(int a, int b)
        {
            int modm, cixma, toplama, vurma, bolme;
            return a + b;

        }

        public static int Calculator(int a, int b, out float bolme, out int vurma, out int toplama, out int cixma, out int modm)
        {
            modm = a % b;
            cixma = a - b;
            toplama = a + b;
            vurma = a * b;
            bolme = a / b;
            return a + b;

        }

    }
}
