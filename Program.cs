class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett nummer!");
        
        int nummer;
        string siffra = Console.ReadLine();

        bool isNumber = int.TryParse(siffra, out nummer);

        Console.WriteLine("Skrev du ett nummer: " + isNumber);
        
    }

}