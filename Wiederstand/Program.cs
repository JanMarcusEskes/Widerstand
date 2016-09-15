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
      R1 = Double.Parse(Console.ReadLine());
      Console.WriteLine("Wiederstand 2: ");
      R2 = Double.Parse(Console.ReadLine());
      Console.WriteLine("Wiederstand 3: ");
      R3 = Double.Parse(Console.ReadLine());
      double Ergebnis = 1 / ((1 / (R1 + R2)) + (1 / R3));
      Console.WriteLine("Der Gesamtwiederstand beträgt: " + Ergebnis + " Ohm");
      Console.ReadLine();
    }
  }
}
