using System;

namespace Task8
{
    internal class Program
    {
        private static int passwordGenerator(int passwordLength)
        {
            const string allowedChars = "0123456789";
            var random = new Random();
            string chars = string.Empty;    

            for (var i = 0; i < passwordLength; i++)
            {
                chars  += allowedChars[random.Next(0, allowedChars.Length)];
            }
            
            return Convert.ToInt32(chars);
        }

        public static void Main(string[] args)
        {
            int createdpass = passwordGenerator(8);
            
            Console.WriteLine(createdpass);

          
           
            fddsffdsfds

            Console.WriteLine("Please enter genarated code");
            var code = Convert.ToInt32(Console.ReadLine());

            if (code == createdpass)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
           
        }
    }
}