using System;

namespace retocero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Ingresa tu Nombre");
            string nombre = Console.ReadLine();
            
            
            Console.WriteLine("Hola, Ingrese su peso corporal en Kilos");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Hola, Ingrese su altura en metros ejemplo 1,75");
            double altura = double.Parse(Console.ReadLine());
            //string altura = Console.ReadLine();
            
            double alturac2 = altura * altura;
            
            double resultado1 = peso / alturac2;
            double resultado = Math.Round(resultado1, 2);
            //Console.WriteLine(alturac2);
            if (resultado < 16)
            {
                    Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Delgadez severa");
            }
            
            else if ((resultado >= 16) && (resultado <= 16.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Delgadez moderada");
            }
            else if ((resultado >= 17) && (resultado <= 18.49))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Delgadez Aceptable");
            }
            else if ((resultado >= 18.5) && (resultado <= 24.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Peso Normal");
            }
            else if ((resultado >= 25) && (resultado <= 29.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Sobre Peso");
            }
            else if ((resultado >= 30) && (resultado <= 34.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Obesidad Tipo I");
            }
            else if ((resultado >= 35) && (resultado <= 39.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Obesidad Tipo II");
            }
            else if ((resultado >= 40) && (resultado <= 49.99))
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Obesidad Tipo III o Morbida");
            }
            else if (resultado >= 50 )
            {
                Console.WriteLine("Hola "+ nombre + "Tu IMC es: " + resultado + " y tu estas en Obesidad Tipo IV o Extrema");
            }
           
        }
    }
}
