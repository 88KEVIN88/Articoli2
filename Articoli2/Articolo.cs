using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Articolo2
{
    internal class Articolo
    {
        private int _codice;
        private string _descrizione;
        private double _prezzo;
        private bool _tessera;


        public Articolo(int codice, string descrizione, double prezzo, bool tessera)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Tessera = tessera;
        }
        public Articolo()
        {
            Codice = 1;
            Descrizione = string.Empty;
            Prezzo = 1;
            Tessera = false;
        }
        public int Codice
        {
            get { return _codice; }
            set
            {
                if (_codice >= 0)
                {
                    _codice = value;
                }
                else
                {
                    throw new ArgumentException("Valore del codice prodotto invalido");
                }
            }
        }
        public Articolo Clone()
        {
            return (Articolo)this.MemberwiseClone();
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as Articolo);
        }

        public bool Equals(Articolo articoli)
        {
            return articoli != null && Codice == articoli.Codice && Descrizione == articoli.Descrizione && Prezzo == articoli.Prezzo;
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set
            {
                if (value != null)
                {
                    _descrizione = value;
                }
                else
                {
                    throw new ArgumentException("Input non valido riprovare");
                }
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set
            {
                _prezzo = value;
                if (_prezzo != 0)
                {
                    _prezzo = value;
                }
                else
                {
                    throw new ArgumentException("Il prezzo deve essere > 0");
                }
            }
        }
        public bool Tessera
        {
            get { return _tessera; }
            set { _tessera = value; }
        }
        //Metodi
        public virtual double Sconta(bool c)
        {
            return Math.Round(Prezzo - (Prezzo * 5) / 100, 2);
        }
        //metodo ToString
        public override string ToString()
        {
            return "Codice: " + Codice.ToString() + "; Descrizione: " + Descrizione.ToString() + "; Prezzo: " + Prezzo.ToString();
        }


    }
}
