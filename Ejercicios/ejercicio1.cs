using System;

class ejercicio1
{
    public static void Main(string[] args)
    {
        string name1, name2;
        int age1, age2;

        Console.Write("Ingrese el nombre de la primera persona: ");
        name1 = Console.ReadLine();
        Console.Write("Ingrese la edad de la primera persona: ");
        age1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el nombre de la segunda persona: ");
        name2 = Console.ReadLine();
        Console.Write("Ingrese la edad de la segunda persona: ");
        age2 = Convert.ToInt32(Console.ReadLine());

        if(age1 > age2)
        {
            Console.Write($"{name1} es mayor que {name2}.");
        }
        else if(age2 > age1)
        {
            Console.Write($"{name2} es mayor que {name1}.");
        }
        else if(age1 == age2)
        {
            Console.Write($"{name1} y {name2} tienen la misma edad.");
        }


    }
}