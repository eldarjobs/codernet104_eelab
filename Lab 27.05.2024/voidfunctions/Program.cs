internal class Program
{
    private static void Main(string[] args)
    {
        /*Name()*/;

        ToupperCaseFirstletter("name");
    }




    //public string ConvertToUpperCaseFirstletterCustom(string nametoTitleCase)
    //{
    //    char[] charArray = nametoTitleCase.ToCharArray();

    //    for (int i = 0; i < charArray.Length; i++)
    //    {
    //    }


    //    return new string(charArray);
    //}


    //public string ConvertToUpperCaseCustom(string surname)
    //{
    //    char[] charArray = surname.ToCharArray();
    //    for (int i = 0; i < charArray.Length; i++)
    //    {
    //        if (charArray[i] >= 'a' && charArray[i] <= 'z')
    //        {

    //            charArray[i] = (char)(charArray[i] - 'a' + 'A');
    //        }
    //    }
    //    return new string(charArray);
    //}
    public static void ConvertUp(string surname)
    {
        int indexchar = 0;
        for (int i = 0; i < surname.Length; i++)
        {
            indexchar = surname[i];
            if (indexchar > 61)
            {
                indexchar -= 32;
                Console.Write((char)indexchar);
            }
        }
    }

    public static void ToupperCaseFirstletter(string name)
    {
        char newarray = name[name.Length];

        bool check = true; 

        for (int i = 0; i < name.Length; i++)
        {
            if (name[0] >= 97 && check == true)
            {

            }
        }
    }








    //public static void Name()
    //{
    //    Console.WriteLine("write name");
    //    string name = Console.ReadLine();
    //    ToupperCaseFirstletter(name);

    //    Console.WriteLine("write surname");
    //    string surname = Console.ReadLine();

    //    ConvertUp(surname);

    //    Console.WriteLine("write domain");
    //    string domain = Console.ReadLine();


    //    AddUser(name, surname, domain);

    //    surname = surname.ToUpper();


    //}

    //public static void AddUser(string name, string surname, string domain)
    //{
    //    if (name == null || surname == null || domain == null)
    //    {
    //        Console.WriteLine("enter name, surname and domain");
    //        return;
    //    }

    //    if (domain == "hot")
    //    {

    //        Console.WriteLine(name + "." + surname + "@hotmail.com");
    //    }
    //    else
    //    {
    //        Console.WriteLine(name + "." + surname + "@" + domain + ".com");

    //    }


    //}

}

