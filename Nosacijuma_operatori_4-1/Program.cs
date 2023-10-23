using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ievadiet skaitli: ");
        int skaitlis = int.Parse(Console.ReadLine());

        if (skaitlis % 2 == 0)
        {
            Console.WriteLine(skaitlis + " ir pāra skaitlis.");
        }
        else
        {
            Console.WriteLine(skaitlis + " ir nepāra skaitlis.");
        }
    }
}