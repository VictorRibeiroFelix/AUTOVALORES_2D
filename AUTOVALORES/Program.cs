using System;
 class Program
{
    static void Main(string[] args)
    {
        int a1 = 0, a2 = 0;
        int b1 = 0, b2 = 0;

        Console.WriteLine("\nEscolha valor a1");
        a1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha valor a2");
        a2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha valor b1");
        b1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha valor b2");
        b2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nT(x,y) = ({a1}x + {b1}y , {a2}x + {b2}y)");

        Console.WriteLine("\ne = {(1,0) , (0,1)}");

        Console.WriteLine($"\nT(1,0) = ({a1} , {a2})");
        Console.WriteLine($"\nT(0,1) = ({b1} , {b2})");

        Console.WriteLine($"\n    ({a1}  {b1})");
        Console.WriteLine($"A= ({a2}  {b2})");

        Console.WriteLine($"\n|{a1} - L  {b1}|");
        Console.WriteLine($"\n|{a2}    {b1} - L|");

        int c = 0, d = 0;

        c = (-a1 - b2);
        d = ((a1 * b2) - (a2 * b1));

        Console.WriteLine($"\nL^2 + {c} * L + {d} = 0");

        int delta = 0;

        delta = (((int)Math.Pow(c, 2)) - (4 * 1 * d));

        if (delta > 0) {
            int x1 = 0, x2 = 0;
            Console.WriteLine($"\nDelta = {delta}");

            x1 = ((int)((-c + Math.Sqrt(delta)) / 2));
            x2 = ((int)((-c - Math.Sqrt(delta)) / 2));

            Console.WriteLine($"\n L1 = {x1}");
            Console.WriteLine($"\n L2 = {x2}");

        } else if (delta == 0) {
            int x1 = 0;
            Console.WriteLine($"\nDelta = {delta}");

            x1 = ((int)((-c + Math.Sqrt(delta)) / 2));

            Console.WriteLine($"\n L1 e L2 = {x1}");

        }
        else
        {
            Console.WriteLine("\n Nao tem resuldado: delta < 0");
        }
    }
}