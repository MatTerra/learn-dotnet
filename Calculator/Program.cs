using System;

namespace Calculator
{
    class Program
    {
        static float GetValue(int ord, float lastResult)
        {
            Console.WriteLine($"{(ord == 1 ? "Primeiro" : "Segundo")} Valor(ou r para o último resultado):");
            var ent = Console.ReadLine();
            ent = ent.Trim();
            float value;
            if (ent == "r")
                return lastResult;
            return float.Parse(ent);


        }
        static void Main(string[] args)
        {
            float resultado = 0.0f;
            do
            {
                Console.Clear();
                var v1 = GetValue(1, resultado);
                Console.WriteLine("Operador:");
                var operador = (Operacao)char.Parse(Console.ReadLine());
                var v2 = GetValue(2, resultado);

                switch (operador)
                {
                    case Operacao.SOMA:
                        resultado = v1 + v2;
                        break;
                    case Operacao.MULTIPLICACAO:
                        resultado = v1 * v2;
                        break;
                    case Operacao.SUBTRACAO:
                        resultado = v1 - v2;
                        break;
                    case Operacao.DIVISAO:
                        resultado = v1 / v2;
                        break;
                }
                Console.WriteLine($"O resultado é {resultado}");
                Console.WriteLine("Pressione ENTER para fazer outra conta ou q para sair...");
                var c = Console.ReadKey();
                if (c.KeyChar == 'q') System.Environment.Exit(0);
            } while (true);
        }
        enum Operacao
        {
            SOMA = '+',
            SUBTRACAO = '-',
            MULTIPLICACAO = '*',
            DIVISAO = '/'
        }
    }
}
