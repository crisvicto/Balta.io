using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Chamada da função     
            Menu();
        }

        //Função
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma"); 
            Console.WriteLine("2 - Subtração"); 
            Console.WriteLine("3 - Divisão"); 
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção: ");

            // leitura do dado digitado pelo usuário
            short res = short.Parse(Console.ReadLine()); 

            //Chamando as funções
            switch (res)
            {
                case 1: Soma(); break; 
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }
        
        }

        //Criação no método Soma
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine()); //Parse para conversão de valor em string  

            Console.WriteLine(""); 

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            //Faz com que a aplicação não feche retornando ao menu inicial
            Menu(); 

            /*
            Interpolação de Strings
            Console.WriteLine($"O resultado da soma é: {resultado}");  
            Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Utilizando parenteses
            Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            */
        }

        //Criação no método Subtração
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2; 
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey(); //Impede o fechamento automático do programa 
            Menu();


        }

        //Criação no método Divisão
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: "); 
            float v2 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine ($"O resultado da divisão é {resultado}"); 
            Console.ReadKey();
            Menu(); 
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); 

            float resultado = v1 * v2; 
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2)); 
            Console.ReadKey(); 
            Menu();
        }
    }
}
