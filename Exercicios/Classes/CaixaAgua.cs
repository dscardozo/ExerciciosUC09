using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Classes
{
    internal class CaixaAgua
    {
        private int altura;
        private int largura;
        private int profundidade;

        public int CalcularVolume()
        {
            return altura * largura * profundidade;
        }

        public int Altura
        {
            get { return altura; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero");                    
                }
                else
                {
                    altura = value;
                }
            }
        }
        public int Largura
        {
            get { return largura; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero");
                }
                else
                {
                     largura = value;
                }
            }
        }
        public int Profundidade 
        {
            get { return profundidade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero");
                }
                else
                {
                    profundidade = value;
                }
            }
        }
    }
}
