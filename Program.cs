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
            //exercicio3();
            //LacoDoWhileExemplo();
            //exercicio4();
            //exemploWhile();
            //exercicio5();
            exercicio6();
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

        static void LacoDoWhileExemplo()
        {
            int Y;
            Console.Write("Digite um número: ");
            Y = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("O valor de Y é: {0}", Y); //Y--;
                Y = Y - 1;
            } while (Y > 0);

        }

        static void exercicio4()
        {
            int num = 0, maior = 0, menor = 0;

            Console.WriteLine("Digite 30 números para exibir o menor e o maior: ");
            Console.WriteLine("Digite o 1° número: ");
            num = Convert.ToInt32(Console.ReadLine());
            maior = num;
            menor = num;
            for (int x = 1; x < 30; x++)
            {
                Console.WriteLine("Digite o {0}° número: ", x + 1);
                num = Convert.ToInt32(Console.ReadLine());

                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
            }
	        Console.WriteLine("O menor número digitado é: {0}", menor);
            Console.WriteLine("O maior número digitado é: {0}", maior);

        }

        static void exemploWhile() {
			int mes = 0;
			while (!(mes > 0 && mes < 13))
			{
				Console.WriteLine("Digite o seu mês de nascimento: ");
				mes = Convert.ToInt32(Console.ReadLine());
			};
			Console.ReadLine();
			//na primeira entrada, se for diferente da condição ele começa o loop de novo - entrando no loop aceita qualquer 3 entradas e fecha
		}

        static void exercicio5(){
            int n = 0;
            Console.WriteLine("Digite o número de repetições (maior que zero): ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n==0){
				Console.WriteLine("Digite o número de repetições (maior que zero): ");
				n = Convert.ToInt32(Console.ReadLine());
            }else{
                for (int x = 1; x <= n; x++){
                    Console.WriteLine(x);
                }
            }
			// numero maximo para o Int32 2147483647
		}

        static void exercicio6(){
            int num = 0, soma = 0, resto = 0, produto = 0;

            Console.WriteLine("Digite 15 números: ");
			Console.WriteLine("Digite o 1° número: ");
			num = Convert.ToInt32(Console.ReadLine());
			soma = num;
			resto = num;
			produto = num;

            for (int x = 1; x < 15; x++){
				Console.WriteLine("Digite o {0}° número: ", x + 1);
				num = Convert.ToInt32(Console.ReadLine());
                soma += num;
                resto -= num;
                produto *= num;
            }
            Console.WriteLine("A soma dos 15 números é: {0}", soma);
            Console.WriteLine("A subtração dos 15 números é: {0}", resto);
            Console.WriteLine("A multiplicação dos 15 números é: {0}", produto);
        }

    }
}