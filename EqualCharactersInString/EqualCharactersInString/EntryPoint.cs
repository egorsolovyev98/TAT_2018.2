using System;

namespace EqualCharactersInString
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            EqualCharactersFinder equalCharactersFinder = new EqualCharactersFinder();
            equalCharactersFinder.FindNumberOfEqualCharacters(inputString);
            equalCharactersFinder.PrintResult();
        }
    }
}