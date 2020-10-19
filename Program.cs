using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Calculadora
    {
        public int[] numeros;

        public Calculadora(int[] numeros1)
        {
            numeros = numeros1;
        }

        public Calculadora() { }

        public void Adicao(int[] numeros)
        {
            int resultado = 0;

            foreach (int numero in numeros)
                resultado += numero;

            Console.WriteLine("O resultado da adição é: " + resultado);
        }

        public void Subtracao(int[] numeros)
        {
            int resultado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0)
                    resultado = numeros[i];
                else
                    resultado -= numeros[i];
            }

            Console.WriteLine("O resultado da subtração é: " + resultado);
        }

        public void Multiplicacao(int[] numeros)
        {
            int resultado = 1;

            foreach (int numero in numeros)
                resultado *= numero;

            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

        public void Divisao(int[] numeros)
        {
            double resultado = 0;

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
        public int numero;

        public Cientifica(int numero1)
        {
            numero = numero1;
        }

        public void Extrair(int numero)
        {

            Convert.ToDouble(numero);

            double resultado = Math.Sqrt(numero);

            Console.WriteLine("A raiz quadrada de " + numero + " é: " + resultado);
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
            while (true)
            {
                int escolha = Menu();

                int numero = 0;
                int[] numeros = { 1 };

                if (escolha == 5)
                {
                    Console.Write("Insira um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Quantos números vai inserir: ");
                    int quant = Convert.ToInt32(Console.ReadLine());

                    numeros = new int[quant];

                    Console.WriteLine("\nInsira um conjunto de números: ");
                    for (int i = 0; i < quant; i++)
                    {
                        Console.Write("Número (" + i + "): ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                }

                Calculadora oper = new Calculadora(numeros);

                Cientifica raiz = new Cientifica(numero);

                switch (escolha)
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
                        raiz.Extrair(numero);
                        break;

                    case 6:
                        return 0;
                }
            }
        }
    }
}
