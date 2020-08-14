using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();
            switch (nome)
            {
                case "Mateus":
                    Console.WriteLine("Hello %s!".Replace("%s",
                                                          nome)); break;
                default: break;
            }
        }
    }
}
