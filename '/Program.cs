
class Program
{
  
    static void Main()
    {
       for (int i = 0; i < 20; i++)
        {
            Console.Write("\rStartar" + new string('.', i % 4) + "   ");
            Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
        }
        string lösenord = "hemligt";
        int försök = 3;

        while (försök-- > 0)
        {
            Console.Write("\nAnge lösenord: ");
            if (Console.ReadLine() == lösenord)
            {
                Console.WriteLine("Inloggning lyckades!");
                StartProgram();
                return;
            }
            Console.WriteLine($"Fel lösenord! {försök} försök kvar.\n");
        }
        //         for (int i = 0; i < 100; i++)
        // {
        //     Console.Write("\rFör många felaktiga försök. Avslutar" + new string('.', i % 4) + "   ");
        //     Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
        // }
        
    }

    static void StartProgram()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write("\rLaddar" + new string('.', i % 4) + "   ");
            Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
        }
        Console.WriteLine("\nJippi!");
    }
}
