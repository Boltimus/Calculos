using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4+2={Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4+2={Aritmetica.Subtrair(4,2)}");

            double t1 = conversoes.converterTemperatura(conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = conversoes.converterTemperatura(conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);
            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"100º Fahrenheit = {t2}º Celsius");


            double d1 = conversoes.converterDistancia(conversoes.ConversaoDistancia.MetrosMihas, 300);
            double d2 = conversoes.converterDistancia(conversoes.ConversaoDistancia.MilhasMetros, 1000);
            Console.WriteLine($"300 metros = {d1} milhas");
            Console.WriteLine($"1000 milhas = {d2} metros");


            Console.ReadKey();
        }
    }
}
