using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDespesas
{
    static class Constantes
    {
        #region Constantes para registo

        public const decimal MaxSeguro = 5000.00M;        // Valor máximo para seguro
        public const decimal MaxCobranca = 2500.00M;      // Valor máximo de cobrança
        public const int MaxPeso = 2000;                  // Peso máximo em gramas
        public const decimal IVA = 1.23M;                 // Valor do IVA (23%)
        public const decimal AvisoRecepcao = 1.85M;       // Valor do Aviso de Recepção para cálculo do Registo Pessoal
        public static readonly decimal[] ValorRegisto = new decimal[] { 2.00M, 2.10M, 2.30M, 3.05M, 5.40M };  // Escalões de valores de registo
        public static readonly int[] Peso = new int[] { 21, 51, 101, 501 };                                   // Escalões de peso
        public static readonly decimal[] ValorCobranca = new decimal[] { 101.00M, 501.00M, 1001.00M };        // Escalões de valores de cobrança
        public static readonly decimal[] TaxaCobranca = new decimal[] { 1.30M, 2.30M, 4.45M, 11.00M };        // Taxas de cobrança
        public static readonly decimal[] ValorSeguro = new decimal[] { 501.00M, 1001.00M, 2501.00M };         // Escalões de valores de seguro
        public static readonly decimal[] TaxaSeguro = new decimal[] { 2.80M, 5.60M, 14.10M, 28.00M };         // Taxas de seguro

        #endregion
    }
}
