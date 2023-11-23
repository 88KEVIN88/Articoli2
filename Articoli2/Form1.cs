using Articolo2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Articoli2
{
    public partial class Form1 : Form
    {
        Articolo[] articoloarr = new Articolo[10000];
        Articolo art = new Articolo();
        public int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leggi l'input dall'utente e crea un nuovo articolo fresco
            int codice = int.Parse(textBox1.Text);
            string descrizione = textBox2.Text;
            double prezzo = double.Parse(textBox3.Text);
            int giorniConsumo = int.Parse(textBox4.Text);
            bool Tessera = checkBox1.Checked;
            articoloarr[cont] = new ArticoloAlimentare(codice, descrizione, prezzo, giorniConsumo, Tessera);
            listView1.Items.Add($"Codice:{codice.ToString()},Descrizione:{descrizione},Prezzo:{articoloarr[cont].Sconta(Tessera).ToString()},Giorni:{giorniConsumo.ToString()},Tessera:{Tessera.ToString()}");
            cont++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Leggi l'input dall'utente e crea un nuovo articolo fresco
            int codice = int.Parse(textBox5.Text);
            string descrizione = textBox6.Text;
            double prezzo = double.Parse(textBox7.Text);
            bool riciclato = checkBox3.Checked;
            bool Tessera = checkBox2.Checked;
            articoloarr[cont] = new ArticoloNonAlimentare(codice, descrizione, prezzo, riciclato, Tessera);
            listView1.Items.Add($"Codice:{codice.ToString()},Descrizione:{descrizione},Prezzo:{articoloarr[cont].Sconta(Tessera).ToString()},Riciclato:{riciclato.ToString()},Tessera:{Tessera.ToString()}");
            cont++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Leggi l'input dall'utente e crea un nuovo articolo fresco
            int codice = int.Parse(textBox8.Text);
            string descrizione = textBox9.Text;
            double prezzo = double.Parse(textBox10.Text);
            int giorni = int.Parse(textBox11.Text);
            int anno = int.Parse(textBox12.Text);
            bool Tessera = checkBox4.Checked;
            articoloarr[cont] = new AlimentareFresco(codice, descrizione, prezzo,anno, giorni, Tessera);
            listView1.Items.Add($"Codice:{codice.ToString()},Descrizione:{descrizione},Prezzo:{articoloarr[cont].Sconta(Tessera).ToString()},Anno:{anno.ToString()},Giorni:{giorni},Tessera:{Tessera.ToString()}");
            cont++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            double tot = 0;

            for (int i = 0; i < cont; i++)
            {
                listView1.Items.Add(articoloarr[i].ToString());
                double sc = articoloarr[i].Sconta(checkBox1.Checked);
                tot += sc;
            }

            listView1.Items.Add($"\n\n {tot}");
        }
       
    }
}
