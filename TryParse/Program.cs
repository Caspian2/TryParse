class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett nummer!");
        
        int nummer;
        string siffra = Console.ReadLine();

      
        if(!int.TryParse(siffra, out nummer))
        {
            Console.WriteLine("Det va inte ett nummer");
        }
        else
        {
            Console.WriteLine("Detta va nummeret " + nummer);
        }
        
    }

}

