global using System;

using Konsolenanwendung.Geometrie;

namespace Konsolenanwendung
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ein Programm für die Berechnung von einem Kreisumfang");
            Console.WriteLine("-----------------------------------------------------"
                + Environment.NewLine);

            while(true) {
                Console.Write("Bitte geben sie einen Radius an: ");

                string? eingabe = Console.ReadLine();
                double umfang = Kreis.BerechneKreisumfang(eingabe);

                if(umfang < 0) {
                    Console.WriteLine($"Der angegebene Radius ist ungültig oder liegt nicht im Wertebereich [0;{uint.MaxValue}].");

                    break;
                }

                Console.WriteLine($"Der Kreisumfang beträgt: {umfang}{Environment.NewLine}");
            }

            Console.WriteLine("Programm wird beendet ...");
        }
    }
}