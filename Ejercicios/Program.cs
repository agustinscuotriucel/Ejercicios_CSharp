using System;

class ejercicio2
{
    public static void Main(string[] args)
    {
        int numero, cifras;

        Console.Write("Ingrese un numero entero y positivo: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if(numero < 0)
        {
            Console.Write("Error. Debe ingresar un numero entero.");
        }
        else
        {
            cifras = 0;
            while (numero > 0)
            {
                numero /= 10; 
                cifras++;
            }
            Console.Write($"El numero {numero} tiene {cifras} cifras.");
        }

    }
}