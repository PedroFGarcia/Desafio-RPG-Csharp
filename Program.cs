using System;
using Desafio_RPG_CSharp.src;

namespace Desafio_RPG_CSharp 
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight", 759, 72);
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard", 574, 89);

            Console.WriteLine(knight.ToString());
            Console.WriteLine(knight.Attack(1));
            Console.WriteLine(knight.Attack(7));
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}