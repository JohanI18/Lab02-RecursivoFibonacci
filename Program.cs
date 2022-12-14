namespace Lab02_RecursivoFibonacci;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int n, k;
        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine()!);
        } while (n <= 1);
        Console.WriteLine("\tSerie números de fibonacci recursivo: ");
        Stopwatch timeMeasureR = new Stopwatch();
        timeMeasureR.Start();
        for (k = 0; k < n; k++)
        {
            Console.WriteLine(FibonacciRecursivo(k));
        }
        timeMeasureR.Stop();
        Console.WriteLine("\n\tSerie números de fibonacci iterativo: ");
        var timeMeasureI = new System.Diagnostics.Stopwatch(); 
        timeMeasureI.Start();
        FibonacciIterativo(n);
        timeMeasureI.Stop();
        Console.WriteLine($"\nTiempo de ejecución recursivo: {timeMeasureR.Elapsed.TotalMilliseconds} ms");
        Console.WriteLine($"Tiempo de ejecución iterativo: {timeMeasureI.Elapsed.TotalMilliseconds} ms");

    }

    static long FibonacciRecursivo(int n) {
            if (n < 2) { return n; }
            else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1); }
            
        }

    static void FibonacciIterativo(int n) {
            int i; long ant1, ant2;
            ant1 = ant2 = 1;
            Console.WriteLine("0 \n1 \n1");
            for (i = 1; i < n - 2; i++)
            {
                int actual = (int)(ant1 + ant2);
                Console.WriteLine(actual);
                ant2 = ant1;
                ant1 = actual;               
            }
        }
}