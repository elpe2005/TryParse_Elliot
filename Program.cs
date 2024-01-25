int resultat;
TryParse(Console.ReadLine(), out resultat);


static bool TryParse(string s, out resultat)
{
    try
    {
        int i = int.Parse(s);
    }
    catch (FormatException)
    {   
        resultat = 0;
        return false;
    }
    
}
