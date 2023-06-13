string[] choices = { "Πέτρα", "Ψαλίδι", "Χαρτί" };
int computerScore = 0;
int playerScore = 0;

string menu = "1) Πέτρα\n2) Ψαλίδι\n3) Χαρτί\n0) Exit";
string ShowResult(int playerChoise, int computerChoise)
{
    if (computerChoise == playerChoise)
        return "Ισσοπαλία";

    // win conditions { "Πέτρα == 0", "Ψαλίδι == 1", "Χαρτί == 2" }  0 - 1, 1 - 2 and 2 - 0
    if (playerChoise - computerChoise == -1 || playerChoise - computerChoise == 2)
    {
        playerScore += 1;
        return "Κερδίσατε";
    }

    else
    {
        computerScore += 1;
        return "Χάσατε";
    }
}

while (true)
{
    Console.WriteLine($"Το σκορ είναι: Υπολογιστής: {computerScore} | Εσείς: {playerScore}");
    Console.WriteLine(menu);

    Console.WriteLine("Παρακαλώ επιλέξτε: ");

    string choise = Console.ReadLine();

    int playerChoise = int.Parse(choise);

    if (playerChoise > 3)
    {
        Console.WriteLine(new string('-', 80));
        Console.WriteLine("Παρακαλώ επιλέξτε έναν αριθμό απο το 0 έως το 3");
        continue;
    }

    if (playerChoise == 0)
        break;

    playerChoise -= 1;

    Console.WriteLine($"Επιλέξατε {choices[playerChoise]}");

    int computerChoise = new Random().Next(choices.Length);

    Console.WriteLine($"Ο υπολογιστής επέλεξε {choices[computerChoise]}");

    Console.WriteLine(ShowResult(playerChoise, computerChoise));


    Console.WriteLine(new string('-', 80));
}

Console.WriteLine("Game Over");