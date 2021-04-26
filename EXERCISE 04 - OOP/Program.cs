using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_04___OOP {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            Calculator calc = new Calculator();

            Console.Write("DIGITE O VALOR DO RAIO: "); double raio = double.Parse(Console.ReadLine());
            double circ = calc.Circle(raio);
            double volume = calc.Volume(raio);
            Console.WriteLine("CIRCUNFERENCIA: " + circ.ToString("F2"));
            Console.WriteLine("VOLUME: " + volume.ToString("F2"));
            Console.WriteLine("VALOR DE PI: " +calc.Pi);
        }

    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
