namespace Oppgave_Random_Hobby_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Run();
            void Run()
            {
                while (true)
                {
                    Console.WriteLine("Hvem er det som har lyst på en ny Hobby?");
                    string name = Console.ReadLine() ?? "";
                    //if (name == "" || name == null) name = "Du";
                    if (string.IsNullOrEmpty(name)) name = "Du";

                    int randomNumber = r.Next(1,6);
                    GetHobby(randomNumber, name);

                    Console.ReadKey();
                }
            }

            void GetHobby(int num, string name)
            {
                if (num == 1) Console.WriteLine($"{name} er nå en surfer! Prøv å ikke dette av brettet!");
                else if (num == 2) Console.WriteLine($"{name} er nå en fotograf! Smil!!!");
                else if (num == 3) Console.WriteLine($"{name} er nå en baker! På tide åpne ett bakeri.");
                else if (num == 4) Console.WriteLine($"{name} har nå startet med Yoga! Pust dypt inn, og sakte ut.");
                else if (num == 5) Console.WriteLine($"{name} har begynt med sjonglering! Noen tok titlen klasse klovn på alvor");
            }

            void GetHobbySwitch(int num, string name)
            {
                switch (num)
                {
                    case 1: 
                        Console.WriteLine($"{name} er nå en surfer! Prøv å ikke dette av brettet!"); 
                        break;
                    case 2:
                        Console.WriteLine($"{name} er nå en fotograf! Smil!!!");
                            break;
                    case 3:
                        Console.WriteLine($"{name} er nå en baker! På tide åpne ett bakeri.");
                        break;
                    case 4:
                        Console.WriteLine($"{name} har nå startet med Yoga! Pust dypt inn, og sakte ut.");
                        break;
                    case 5:
                        Console.WriteLine($"{name} har begynt med sjonglering! Noen tok titlen klasse klovn på alvor");
                        break;
                }
            }
            
        }
    }
}
