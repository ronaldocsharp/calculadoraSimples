namespace calculadoraSimples
{
    internal class Program
    {
        enum Menu
        {
            Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair
        }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) 
            {
                Console.WriteLine("|Calculadora C#|");
                Console.WriteLine("|Menu de Opções|");
                Console.WriteLine();
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Console.WriteLine();
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.Clear(); 

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;

                }

            }

        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int nun2 = int.Parse(Console.ReadLine());
            int resultado = nun1 + nun2;
            Console.WriteLine($"Resultado:{resultado} ");  
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtrai de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int nun2 = int.Parse(Console.ReadLine());
            int resultado = nun1 - nun2;
            Console.WriteLine($"Resultado:{resultado} ");  
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int nun2 = int.Parse(Console.ReadLine());
            float resultado = (float)nun1 / (float)nun2; 
            Console.WriteLine($"Resultado:{resultado.ToString("N2")} ");  
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros!");
            Console.WriteLine("Digite o primeiro numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int nun2 = int.Parse(Console.ReadLine());
            int resultado = nun1 * nun2;
            Console.WriteLine($"Resultado:{resultado} ");  
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de um numero!");
            Console.WriteLine("Digite a Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Potencia: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"Resultado:{resultado} ");  
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero!");
            Console.WriteLine("Digite o numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(nun1);
            Console.WriteLine($"Resultado:{resultado} "); 
            Console.WriteLine("Aperte ENTER para voltar para o menu! ");
            Console.ReadLine();
        }

    }
}
