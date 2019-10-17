using System;
using CharacterLibrary;


namespace CharacterCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            character.GenerateCharacter();
            Console.WriteLine(character.ToString());
        }
    }
}
