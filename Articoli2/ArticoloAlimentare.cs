using Articolo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Articoli2
{
    internal class ArticoloAlimentare : Articolo
    {
        private int _anno;
        public int AnnoScadenza
        {
            get { return _anno; }
            set
            {
                _anno = value;
                if (_anno != 0)
                {
                    _anno = value;
                }
                else
                {
                    throw new ArgumentException("L'anno di scadenza non puó essere 0");
                }
            }
        }
        public ArticoloAlimentare(int codice, string descrizione, double prezzo, int annoScadenza, bool tessera)
            : base(codice, descrizione, prezzo, tessera)
        {
            AnnoScadenza = annoScadenza;
        }
        public ArticoloAlimentare() : base()
        {
            AnnoScadenza = 0;
        }
        public override double Sconta(bool tessera)
        {
            double scontato = Prezzo;
            if (tessera)
            {
                scontato = scontato - (scontato * 5) / 100;
            }
            if (AnnoScadenza == DateTime.Today.Year)
            {
                scontato = scontato - (scontato * 20) / 100;
            }
            return Math.Round(scontato, 2);

        }
        //metodo ToString
        public override string ToString()
        {
            return base.ToString() + "; Scadenza: " + AnnoScadenza.ToString();
        }
    }
}
