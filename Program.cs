using System;

namespace ConsoleApp2
{
    class Calculadora
    {
        public decimal numero;
        public decimal[] numeros;

        public Calculadora(decimal[] numeros1)
        {
            numeros = numeros1;
        }

        public void Adicao(decimal[] numeros)
        {
            decimal resultado = 0;

            foreach(decimal numero in numeros)
                resultado += numero;

            Console.WriteLine("O resultado da adição é: " + resultado);
        }

        public void Subtracao(decimal[] numeros)
        {
            decimal resultado = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                if(i == 0)
                    resultado = numeros[i];
                else
                    resultado -= numeros[i];
            }

            Console.WriteLine("O resultado da subtração é: " + resultado);
        }

        public void Multiplicacao(decimal[] numeros)
        {
            decimal resultado = 1;

            foreach(decimal numero in numeros)
                resultado *= numero;

            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

        public void Divisao(decimal[] numeros)
        {
            decimal resultado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0)
                    resultado = numeros[i];

                else
                    resultado /= numeros[i];
            }

            Console.WriteLine("O resultado da divisão é: " + resultado);
        }
    }

    class Cientifica : Calculadora
    {
        public void Extrair(numero)
        {

        }
    }

    class Program
    {
        static int Menu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|           Nova Calculadora             |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|   (1) - Adicionar números              |");
            Console.WriteLine("|   (2) - Subtrair números               |");
            Console.WriteLine("|   (3) - Multiplicar números            |");
            Console.WriteLine("|   (4) - Dividir números                |");
            Console.WriteLine("|   (5) - Extrair a raíz de um número    |");
            Console.WriteLine("|   (6) - Fechar programa                |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("------------------------------------------");
            Console.Write("- Insira operação a efetuar: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return escolha;
        }

        static int Main(string[] args)
        {
            while(true)
            {
                int escolha = Menu();

                decimal numero = 0;
                decimal[] numeros = new decimal[10000];

                if(escolha == 5)
                {
                    Console.Write("Insira um número: ");
                    numero = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Insira um conjunto de números: ");
                    for(int i = 0; i < i++; i++)
                    {
                        Console.Write("Número (" + (i++) + "): ");

                        Console.WriteLine();
                    }
                }

                Calculadora oper = new Calculadora(numeros);

                Calculadora raiz = new Cientifica(numero);

                switch(escolha)
                {
                    case 1:
                        oper.Adicao(numeros);
                        break;

                    case 2:
                        oper.Subtracao(numeros);
                        break;

                    case 3:
                        oper.Multiplicacao(numeros);
                        break;

                    case 4:
                        oper.Divisao(numeros);
                        break;

                    case 5:
                        
                        break;

                    case 6:
                        return 0;
                }
            }
        }
    }
}
