using System;

namespace Tarea19
{
    class Program
    {
        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1\n");

            int num1 = 3;
            int num2 = 4;

            Console.WriteLine($"numero 1: {num1}\nnumero2: {num2}");
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Multiplicacion: " + (num1*num2));
            Console.WriteLine("Division: " + (num1/num2));
            Console.WriteLine("Modulo: " + (num1%num2));
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2\n");
            

            int N = 2;
            double A = 3.5;
            char C = 'a';

            Console.WriteLine($"N: {N}");
            Console.WriteLine($"A: {A}");
            Console.WriteLine($"C: {C}");

            Console.WriteLine($"Suma de N + A: {N + A}");
            Console.WriteLine($"Diferencia de A - N: {A - N}");
            Console.WriteLine($"Valor numérico de C: {(int)C}");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3\n");

            int X = 4;
            int Y = 10;
            double N = 1.56;
            double M = 2.57;

            Console.WriteLine($"Valor de X: {X}");
            Console.WriteLine($"Valor de Y: {Y}");
            Console.WriteLine($"Valor de N: {N}");
            Console.WriteLine($"Valor de M: {M}");
            Console.WriteLine($"Suma X + Y: {X + Y}");
            Console.WriteLine($"Diferencia X - Y: {X - Y}");
            Console.WriteLine($"Producto X * Y: {X*Y}");
            Console.WriteLine($"Cociente X / Y: {X / Y}");
            Console.WriteLine($"Resto X % Y: {X % Y}");
            Console.WriteLine($"Suma N + M: {N + M}");
            Console.WriteLine($"Diferencia N - M: {N - M}");
            Console.WriteLine($"Producto N * M: {N*M}");
            Console.WriteLine($"Cociente N / M: {N / M}");
            Console.WriteLine($"Resto N % M: {N % M}");
            Console.WriteLine($"Suma X + N: {X + N}");
            Console.WriteLine($"Cociente Y / M: {Y / (int)M}");
            Console.WriteLine($"Resto Y % M: {Y % (int)M}");
            Console.WriteLine($"Doble de X: {X*2}");
            Console.WriteLine($"Doble de Y: {Y*2}");
            Console.WriteLine($"Doble de N: {N*2}");
            Console.WriteLine($"Doble de M: {M*2}");

            double suma = X + Y + N + M;
            Console.WriteLine($"Suma total: {suma}");

            double producto = X * Y * N * M;
            Console.WriteLine($"Producto total: {producto}");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ejercicio 4\n");

            int N = 23;
            Console.WriteLine($"Valor inicial de N: {N}");
             
            N += 77;
            Console.WriteLine($"N incrementado en 77: {N}");

            N -= 3;
            Console.WriteLine($"N decrementado en 3: {N}");

            N *= 2;
            Console.WriteLine($"Doble de N: {N}");

        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5\n");

            int A = 2;
            int B = 5;
            int C = 10;
            int D = 100;

            Console.WriteLine("Antes:");
            Console.WriteLine($"A={A}\nB={B}\nC={C}\nD={D}");

            //guardo una copia del valor original de B porque al final cuando tenga que asignarlo a D ya no tendría su valor original
            int copiaB = B;
            B = C;
            C = A;
            A = D;
            D = copiaB;


            Console.WriteLine("Despues:");
            Console.WriteLine($"A={A}\nB={B}\nC={C}\nD={D}");


        }

        static void Main(string[] args)
        {
            Ejercicio1();
            Console.WriteLine("----------------------\n\n");
            Ejercicio2();
            Console.WriteLine("----------------------\n\n\n");
            Ejercicio3();
            Console.WriteLine("----------------------\n\n\n");
            Ejercicio4();
            Console.WriteLine("----------------------\n\n\n");
            Ejercicio5();
        }
    }
}
