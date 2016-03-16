using System;

namespace IntroducingMethods
{
    /// <summary>
    /// Exempel från Essential C# 6.0, kapitel 4, sidan 169-170.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Lokala variabler för förnamn, efternamn, fullständigt namn och initialer.
            string firstName;
            string lastName;
            string fullName;
            string initials;

            // Hämta indata från användaren.
            Console.WriteLine("Hallå där!");
            firstName = GetUserInput("Skriv in ditt förnamn: ");
            lastName = GetUserInput("Skriv in ditt efternamn: ");

            // Bestäm fullständigt namn samt initialer och presentera detta.
            fullName = GetFullName(firstName, lastName);
            initials = GetInitials(firstName, lastName);
            DisplayGreeting(fullName, initials);
        }

        static string GetUserInput(string prompt)
        {
            // Lokal variabel för hantering av indata.
            string input;

            // Skriv ut ledtext och läs in datat som användaren matar in.
            Console.Write(prompt);
            input = Console.ReadLine();

            // Returnera inläst data
            return input;
        }

        // C# 6.0:s "expression bodied-method" har avsevärt komprimerat 
        // metodkroppen i kursbokens ursprungliga version av 'GetFullName()'

        // static string GetFullName(string fName, string lName) => $"{fName} {lName}";

        // Jämfört med den expanderade definitionen nedan, kan användning av 
        // lambda-uttryck förenkla skrivandet av okomplicerade metoder likt denna.
        // Den eleganta och till synes effektiva syntaxen påverkar dock inte faktisk
        // prestanda, då båda alternativ expanderas till samma IL-kod vid körning (runtime).
        // Även om den är raffinerad finns alltså inget högre ändamål med denna 
        // form av förenklad syntax. 
        // I sammanhang där intuitiv och snabb förståbarhet av koden ges hög prioritet
        // är ofta en utvecklad definition likt nedan att föredra.

        static string GetFullName(string fName, string lName)
        {
            // Att först definiera en lokal variabel för det fullständiga namnet ...
            string result;

            // ... gör det möjligt att synliggöra flera steg i metodens arbete.
            // Formatera först för- och efternamn till ett fullständigt namn ...            
            result = String.Format("{0} {1}", fName, lName);

            // ... avsluta därefter metoden genom att returnera resultatet.
            return result;
        }

        private static string GetInitials(string firstName, string lastName)
        {

            return $"{firstName[0]}.{lastName[0]}.";
        }

        static void DisplayGreeting(string fullName, string initials)
        {
            // Skriv ut det fullständiga namnet samt initialerna och lämna metoden.
            Console.WriteLine($"Hej {fullName}! Dina initialer är {initials}");

            return; // Denna sats behövs egentligen inte då metodens returtyp är void,
                    // men är alltså fullt möjligt att använda även här.
        }
    }
}
