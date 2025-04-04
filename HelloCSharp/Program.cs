using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Halo dari C#!");

        Console.Write("Siapa nama kamu? ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Halo, {nama}!");
    }
}
