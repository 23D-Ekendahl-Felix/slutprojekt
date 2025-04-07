using System.Diagnostics;
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
                ladda();
                return;
            }
            Console.WriteLine($"Fel lösenord! {försök} försök kvar.\n");
        }
                for (int i = 0; i < 10; i++)
        {
            Console.Write("\rFör många felaktiga försök. Avslutar" + new string('.', i % 4) + "   ");
            Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
        }
        for (int i = 0; i < 25; i++)
        {
            var startInfo = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
        
    }

    static void ladda()
    {
                for (int i = 0; i < 20; i++)
        {
            Console.Write("\rLaddar" + new string('.', i % 4) + "   ");
            Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
            StartProgram()
        }
    }
    static void StartProgram()
    {

        Console.WriteLine("\nMeny:");
        Console.WriteLine("1. Ändra instälningar");
        Console.WriteLine("2. Avsluta");
        Console.Write("Välj ett alternativ: ");
        
        string val = Console.ReadLine();

        if (val == "1")
        {
            Console.WriteLine("Ändra instälningar");
            List<string> inställningar = new List<string>
        {
            "System 32",
            "Ändra bakgrundsfärg",
            "Ändra textstorlek",
            "Återgå till huvudmenyn"
        };
                for (int i = 0; i < inställningar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {inställningar[i]}");
        }

        Console.Write("Välj ett alternativ (1-4): ");
        string inställningarval = Console.ReadLine();

        if (inställningarval == "1")
        {
            val1()
        }
        else if (inställningarval == "2")
        {
            Console.WriteLine("Bakgrundsfärg inte ändrad.");
        }
        else if (inställningarval == "3")
        {
            Console.WriteLine("Textstorlek inte ändrad.");
        }
        else if (inställningarval == "4")
        {
            StartProgram();
            return;
        }
        else
        {
            Console.WriteLine("Ogiltigt val. Försök igen.");
        }
         }


        else if (val == "2")
        {
                            for (int i = 0; i < 100; i++)
        {
            Console.Write("\rAvslutar" + new string('.', i % 4) + "   ");
            Thread.Sleep(1000); //startar en laddning och väntar 1 sek mellan updatering i 60 sek
        }
        }
        else
        {
            Console.WriteLine("Ogiltigt val.");
        }
    }

    static void val1()
    {
                    Console.WriteLine("vill du radera");
            string radera = Console.ReadLine();
            if (radera == "ja")
            {
            System32(int num);
            return;
            }
            else if (radera == "nej")
            {
            System32(int num);
            return;
            }
    }
    static void System32(int num)
    {
                for (int i = 0; i < num; i++)
        {
            var startInfo = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
    }

}