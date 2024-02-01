int resultat;
if (TryParse(Console.ReadLine(), out resultat))
{
    Console.WriteLine(resultat);
}
else 
{
    Console.WriteLine("Skriv in en siffra.");
}

static bool TryParse(string s, out int resultat)
{
    try
    {
        resultat = int.Parse(s);
    }
    catch (FormatException)
    {   
        resultat = 0;
        return false;
    }
    return true;
}
