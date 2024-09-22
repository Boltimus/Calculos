using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal static class conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Tipo de conversão de distancias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMihas,
            MilhasMetros
        }

        /// <summary>
        /// Conversão da temperatura
        /// </summary>
        /// <param name="conversao">A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>

        public static double converterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Conversão da distância
        /// </summary>
        /// <param name="conversao">A conversão a efetuar</param>
        /// <param name="temperatura">A distância a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>

        public static double converterDistancia(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMihas)
            {
                return distancia*0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia*1609.344;
            }
            else
            {
                return -1;
            }
        }


    }
}
