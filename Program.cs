using System;

namespace EstruturaRepeticao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// ExemploFor01();
			// ExemploFor02();
			// Tabuada();
			//dezValores();
			exercicio3();
			Console.ReadKey();
        }

		static void ExemploFor01()
		{
			for (int x = 1; x <= 10; x++)
			{
				Console.WriteLine("O valor de x é: {0}", x);
			}
		}

		static void ExemploFor02()
		{
			for (int j = 0; j <= 10; j += 2)
			{
				Console.WriteLine("O valor de J é: {0}", j);
			}
		}

		static void Tabuada()
		{
			int a, b;
			Console.WriteLine("Digite o número para tabuada: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o número limite: ");
			b = Convert.ToInt32(Console.ReadLine());

			for (int c = 0; c <= b; c++)
			{
				int d = a * c;
				Console.WriteLine("{0}x{1} = {2}", a, c, d);
			}
		}

		static void dezValores()
		{
			int media = 0;

			Console.WriteLine("Digite 10 números para o cálculo da média: ");
			for (int x = 0; x <= 9; x++)
			{
				Console.WriteLine("Digite o {0}° número: ", x + 1);
				media = media + Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("A média dos valores digitados é: {0}", media / 10);
		}

		static void exercicio3()
		{
			int valor1, valor2, soma = 0;
			Console.WriteLine("Digite o valor 1: ");
			valor1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o valor 2: ");
			valor2 = Convert.ToInt32(Console.ReadLine());
			for (int x = valor1 + 1; x < valor2; x++)
			{
				if (x % 2 == 0)
				{
					soma = x + soma;
				}
				// soma += (x % 2 == 0 ? x : 0);
			}
			Console.WriteLine("A soma dos valores pares entre os números digitados é: {0}", soma);
		}
    }
}
