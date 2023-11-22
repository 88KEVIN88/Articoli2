using Articolo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articoli2
{
    internal class ArticoloNonAlimentare : Articolo
    {
        public string Materiale;
        public string mat
        {
            get { return Materiale; }
            set
            {
                if (Materiale != null)
                {
                    Materiale = value;
                }
                else
                {
                    throw new ArgumentException("Il materiale deve essere scritto");
                }
            }
        }
        public bool Riciclabile { get; set; }

        public ArticoloNonAlimentare(int codice, string descrizione, double prezzo, bool riciclabile, bool tessera)
            : base(codice, descrizione, prezzo, tessera)
        {

            Riciclabile = riciclabile;
        }

        public override double Sconta(bool tessera)
        {
            double sconta = Prezzo;
            if (tessera)
            {
                sconta = sconta - (sconta * 5) / 100;
            }
            if (Riciclabile)
            {
                sconta = sconta - (sconta * 10) / 100;
            }
            return Math.Round(sconta, 2);
        }
    }
}
