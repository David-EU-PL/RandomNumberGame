namespace RandomNumberGanme
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var random = new Random();
            var randomNumber = random.Next(0,100);
            Console.WriteLine("Udało Ci się wylosować jedną z liczb od 0 do 100. Spróbuj odgadnąć jaka to liczba :)" );
            var numberOfTries = 0;

            while (true)
            {
                numberOfTries++;
                Console.WriteLine("\nPodaj Twój typ liczby: ");
                var userNumber = GetNumber();

                if (userNumber < randomNumber)
                {
                    Console.WriteLine("Twoja liczba jest mniejsza od wylosowanej. Możesz spróbować ponownie.");
                    continue;
                }
                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Twoja liczba jest większa od wylosowanej. Możesz spróbować ponownie.");
                    continue;
                }
                Console.WriteLine($"BRAWO!!! Udało Ci się wylosować liczbę w {numberOfTries} próbach.");
                break;
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę. Możesz spróbować ponownie.\n");
                    continue;
                 
                }
                return number;
            }
        }
    }
}

