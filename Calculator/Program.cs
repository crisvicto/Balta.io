using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Chamada do método Multiplicação      
            Multiplicacao();
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
        }
    }
}
