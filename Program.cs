using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Autorzy(I semestr niestacjonarne - informatyka): ");
        Console.WriteLine("Rafał Kaczyński 119787 gr1");
        Console.WriteLine("Kacper Pięta 122923 gr1");
        Console.WriteLine("Nataniel Marciniak 122845 gr1");
        Console.WriteLine("Patryk Michalak 125078 gr1");

        Console.WriteLine("Podaj początek:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj koniec:");
        int end = int.Parse(Console.ReadLine());

        while (start >= end) 
        {
            Console.WriteLine("Początek musi być mniejszy od końca, podaj jeszcze raz");

            Console.WriteLine("Podaj początek:");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj koniec:");
            end = int.Parse(Console.ReadLine());
        }

        Random rnd = new Random();
        int randomNumber = rnd.Next(start, end + 1);

        Console.WriteLine("Wylosowano liczbę. Spróbuj ją odgadnąć!");

        int tries = 5;

        for (int i = 0; i < tries; i++)
        {
            Console.WriteLine($"Próba {i + 1} z {tries}: Podaj liczbę:");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Gratulacje! Odgadłeś/aś liczbę.");
                return;
            }
            else if (userNumber > randomNumber && userNumber <= end)
            {
                Console.WriteLine("Twoja liczba jest większa od wylosowanej.");
            }
            else if (userNumber < randomNumber && userNumber >= start)
            {
                Console.WriteLine("Twoja liczba jest mniejsza od wylosowanej.");
            }
            else if (userNumber < start || userNumber > end)
            {
                Console.WriteLine($"Wylosuj liczbę z zakresu od {start} do {end}");
                i--;
            }
            

        }

        Console.WriteLine("Game over!");
        Console.WriteLine($"Wylosowana liczba to: {randomNumber}");
    }
}
