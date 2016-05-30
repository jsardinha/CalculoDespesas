using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDespesas
{
    /// <summary>
    /// Classe para cálculo do envio de registos
    /// </summary>
    class Registo
    {
        #region Fields

        int peso;
        decimal valor;

        #endregion

        #region Constructors

        /// <summary>
        /// Construtor do objecto de registo
        /// </summary>
        /// <param name="peso">peso em gramas</param>
        /// <param name="valor">valor em Euros</param>
        public Registo(int peso, decimal valor)
        {
            this.peso = peso;
            this.valor = valor;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Retorna o valor do objecto
        /// </summary>
        decimal Valor
        {
            get { return valor; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula o valor do registo em mão
        /// </summary>
        /// <returns></returns>
        decimal RegistoMao()
        {
            decimal valor = 0;
            if (peso >= Constantes.Peso[3])
            {
                valor = Constantes.ValorRegisto[4];
            }
            else if (peso >= Constantes.Peso[2] && peso < Constantes.Peso[3])
            {
                valor = Constantes.ValorRegisto[3];
            }
            else if (peso >= Constantes.Peso[1] && peso < Constantes.Peso[2])
            {
                valor = Constantes.ValorRegisto[2];
            }
            else if (peso >= Constantes.Peso[0] && peso < Constantes.Peso[1])
            {
                valor = Constantes.ValorRegisto[1];
            }
            else
            {
                valor = Constantes.ValorRegisto[0];
            }
            return valor;
        }

        /// <summary>
        /// Calcula o valor do registo pessoal
        /// </summary>
        /// <returns></returns>
        decimal RegistoPessoal()
        {
            return RegistoMao() + Constantes.AvisoRecepcao;
        }

        /// <summary>
        /// Calcula a taxa de seguro
        /// </summary>
        /// <returns></returns>
        decimal TaxaSeguro()
        {
            decimal taxa = 0;
            if (valor < Constantes.ValorSeguro[0])
            {
                taxa = Constantes.TaxaSeguro[0];
            }
            else if (valor >= Constantes.ValorSeguro[0] && valor < Constantes.ValorSeguro[1])
            {
                taxa = Constantes.TaxaSeguro[1];
            }
            else if (valor >= Constantes.ValorSeguro[1] && valor < Constantes.ValorSeguro[2])
            {
                taxa = Constantes.TaxaSeguro[2];
            }
            else
            {
                taxa = Constantes.TaxaSeguro[3];
            }
            return taxa;
        }

        /// <summary>
        /// Calcula a taxa de cobrança, com IVA, e retorna o valor arredondado.
        /// </summary>
        /// <returns></returns>
        decimal Cobrança()
        {
            decimal taxa = 0;
            if (valor >= Constantes.ValorCobranca[2])
            {
                taxa = Constantes.TaxaCobranca[3];
            }
            else if (valor >= Constantes.ValorCobranca[1] && valor < Constantes.ValorCobranca[2])
            {
                taxa = Constantes.TaxaCobranca[2];
            }
            else if (valor >= Constantes.ValorCobranca[0] && valor < Constantes.ValorCobranca[1])
            {
                taxa = Constantes.TaxaCobranca[1];
            }
            else
            {
                taxa = Constantes.TaxaCobranca[0];
            }
            return (((taxa * Constantes.IVA) * 1000) + 5) / 1000;
        }

        /// <summary>
        /// Retorna 'true' se o valor de cobrança não ultrapassa o
        /// máximo permitido. Caso contrário retorna 'false'
        /// </summary>
        /// <param name="valor">o valor a cobrar</param>
        /// <returns></returns>
        bool ValorCobrancaValido(decimal valor)
        {
            return valor + this.valor <= Constantes.MaxCobranca;
        }

        /// <summary>
        /// Retorna o valor do registo em mão.
        /// </summary>
        /// <returns></returns>
        public string rm()
        {
            return format(RegistoMao());
        }
        /// <summary>
        /// Retorna o valor do registo em mão à cobrança.
        /// Caso o valor de cobrança não seja válido, retorna 'N/A'.
        /// </summary>
        /// <returns></returns>
        public string rmc()
        {
            if (this.valor == 0)
            {
                return "";
            }
            decimal valor = RegistoMao() + Cobrança();
            if (ValorCobrancaValido(valor))
                return format(valor);
            return "N/A";
        }

        /// <summary>
        /// Retorna o valor do resgisto pessoal.
        /// </summary>
        /// <returns></returns>
        public string rp()
        {
            return format(RegistoPessoal());
        }

        /// <summary>
        /// Retorna o valor de registo com seguro
        /// </summary>
        /// <returns></returns>
        public string rs()
        {
            return format(RegistoPessoal() + TaxaSeguro());
        }

        public string rsc()
        {
            if (this.valor == 0)
            {
                return "";
            }
            decimal valor = RegistoPessoal() + Cobrança() + TaxaSeguro();
            if (ValorCobrancaValido(valor))
            {
                return format(valor);
            }
            return "N/A";
        }

        string format(decimal value)
        {
            return String.Format("{0:0.00}", value);
        }
        #endregion
    }
}
