


void findSubstring()
{
    Console.Write("Ingresa una cadena: ");
    string stringToAnalyse = Console.ReadLine();

    Console.Write("Ingresa una subcadena: ");
    string substring = Console.ReadLine();

    FindSubstringPositions(stringToAnalyse, substring);

    Console.ReadLine();

    void FindSubstringPositions(string stringToAnalyse, string substring)
    {
        Console.WriteLine("Posiciones de inicio de la subcadena:");

        int index = stringToAnalyse.IndexOf(substring);
        while (index != -1)
        {
            Console.WriteLine(index);
            index = stringToAnalyse.IndexOf(substring, index + 1);
        }
    }
}

findSubstring();