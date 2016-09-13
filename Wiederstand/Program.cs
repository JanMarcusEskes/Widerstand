using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederstand
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R3;
            string eingabe;
            Console.WriteLine("Wiederstand 1: ");
            if (Double.TryParse(eingabe = Console.ReadLine(), out R1) == true) R1 = Double.Parse(eingabe);
            else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben!"); Console.ReadLine(); return; }
            Console.WriteLine("Wiederstand 2: ");
            if (Double.TryParse(eingabe = Console.ReadLine(), out R2) == true) R2 = Double.Parse(eingabe);
            else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben!"); Console.ReadLine(); return; }
            Console.WriteLine("Wiederstand 3: ");
            if (Double.TryParse(eingabe = Console.ReadLine(), out R3) == true) R3 = Double.Parse(eingabe);
            else { Console.WriteLine("Es wurde keine gültige Zahl eingegeben!"); Console.ReadLine(); return; }
            double Ergebnis = 1 / ((1 / (R1 + R2)) + (1 / R3));
            Console.WriteLine("Der Gesamtwiederstand beträgt: " + Ergebnis + "Ohm");
            Console.ReadLine();
        }
    }
}
