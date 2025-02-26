Greeting();
GuessNumber();

Console.WriteLine("Program ended");

static void Greeting() {
    DateTime time = DateTime.UtcNow;

    if (time.Hour >= 4 && time.Hour < 8)
    {
        Console.WriteLine("Dobre rano");
        return;
    }

    if (time.Hour < 18)
    {
        Console.WriteLine("Dobry den");
        return;
    }

    if (time.Hour < 22)
    {
        Console.WriteLine("Dobry vecer");
        return;
    }

    Console.WriteLine("Dobru noc");
}

static void GuessNumber() {
    Console.WriteLine("uhadni int cislo od 0 do 1000");

    int number = Random.Shared.Next(0, 1001);
    int guess = -1;

    while (number != guess) {
        if (!int.TryParse(Console.ReadLine(), out guess)) {
            Console.WriteLine("thats not a number you troglodite");
            continue;
        }
        
        if (number > guess) {
            Console.WriteLine("A");
        }
        if (number < guess) {
            Console.WriteLine("V");
        }
    }
    Console.WriteLine($"{guess} is correct!");
}
