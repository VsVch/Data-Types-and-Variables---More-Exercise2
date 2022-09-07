using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            string world = string.Empty;
            for (int i = 0; i < number; i++)
            {
                int letter = char.Parse(Console.ReadLine()) + key;
                char newLetter = (char)letter;
                world += newLetter;
            }
            Console.WriteLine(world);
        }
    }
}
