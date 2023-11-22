using Articoli2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articoli2
{
    internal class AlimentareFresco : ArticoloAlimentare
    {
        public int _GiorniConsumo;
        public int Giorni
        {
            get { return _GiorniConsumo; }
            set
            {
                if (_GiorniConsumo > 0 && _GiorniConsumo <= 6)
                {
                    _GiorniConsumo = value;
                }
                else
                {
                    throw new ArgumentException("Il numero di giorni deve essere compreso fra 1 e 5");
                }
            }
        }

        public AlimentareFresco(int codice, string descrizione, double prezzo, int annoScadenza, int giorniConsumo, bool tessera)
            : base(codice, descrizione, prezzo, annoScadenza, tessera)
        {
            _GiorniConsumo = giorniConsumo;
        }

        public override double Sconta(bool tessera)
        {
            double sconta = Prezzo;
            if (tessera)
            {
                sconta = sconta - (sconta * 5) / 100;
            }
            int numero = 0;
            switch (_GiorniConsumo)
            {
                case 1:
                    numero = 10;
                    break;
                case 2:
                    numero = 8;
                    break;
                case 3:
                    numero = 6;
                    break;
                case 4:
                    numero = 4;
                    break;
                case 5:
                    numero = 2;
                    break;
            }
            sconta = sconta - (sconta * numero) / 100;
            return Math.Round(sconta, 2);
        }
    }
}
