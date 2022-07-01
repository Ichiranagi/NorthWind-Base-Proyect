using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,suma, resta, multiplicacion, modulo;
           
            double division, raiz1,raiz2, potencia;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("\n \t\t\t\t\t\t ULTIMATE FX350");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\n Pulse cualquier tecla para inicializar");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\n Bienvenido a the ultimate calculator by carlos R. ヾ(^▽^*)))");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(">Ingrese el primer numero: ");
            Console.WriteLine();
            Console.WriteLine();
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(">Ingrese el Segundo numero: ");
            Console.WriteLine();
            Console.WriteLine();
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Suma
            suma = n1 + n2;
            Console.WriteLine(">El resultado de la suma es: " + suma);
            Console.WriteLine();
            //Resta
            resta = n1 - n2;
            Console.WriteLine(">El resultado de la resta es: " + resta);
            Console.WriteLine();
            //Multiplicacion
            multiplicacion = n1 * n2;
            Console.WriteLine(">El resultado de la Multiplicacion es: " + multiplicacion);
            Console.WriteLine();
            //Division
            division = n1 / n2;
            Console.WriteLine(">El resultado de la division es: " + division);
            Console.WriteLine();
            //Modulo
            modulo = n1 % n2;
            Console.WriteLine(">El residuo de la division es: " + modulo);
            Console.WriteLine();
            //Potencia
            potencia = Math.Pow(n1,n2);
            Console.WriteLine(">El resultado de la potenciacion es: " + potencia);
            Console.WriteLine();
            //Raiz
            raiz1 = Math.Sqrt(n1);
            Console.WriteLine(">La Raiz cuadrada del primer numero es: " + raiz1);
            Console.WriteLine();
            raiz2 = Math.Sqrt(n2);
            Console.WriteLine();
            Console.WriteLine(">La Raiz cuadrada del Segundo numero es: " + raiz2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________________________________________________");

            Console.WriteLine(">Gracias por usar la ultimate console calculator (´。＿。｀)");

           
           Console.WriteLine("________________________________________________________________________________________________________________________");
           Console.WriteLine("Pulse cualquier tecla dos veces para salir.");
           Console.ReadKey();



        }
    }
}
