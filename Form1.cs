using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valutavalto_from_20241119
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<Valuta> lista = new List<Valuta>();
        void betoltes()
        {
            FileStream fs = new FileStream("..\\..\\src\\valuta.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Valuta v = new Valuta(sr.ReadLine());
                lista.Add(v);
                dgadatok.Rows.Add(v.Nev,v.Ft,v.Devkod,v.Arfolyam,v.devizaosszegszamitas());
            }

            sr.Close();
            fs.Close();
            int dollardb = 0;
            int ftosszeg = 0;
            double dollarosszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Devkod == "USD")
                {
                    dollardb++;
                    ftosszeg += lista[i].Ft;
                    dollarosszeg += lista[i].devizaosszegszamitas();
                }
            }
            lbletszam.Text = "Létszám: " + dollardb.ToString();
            lbftosszeg.Text = "Forint összeg: " + ftosszeg.ToString();
            lbdevizaosszeg.Text = "Devizaösszeg: " + dollarosszeg.ToString();
        }
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txatvaltoossz_TextChanged(object sender, EventArgs e)
        {
            if (txatvaltoossz.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txatvaltoossz.Text);
                }
                catch
                {
                    MessageBox.Show("Forint összegnek egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txatvaltoossz.Clear();
                    txatvaltoossz.Focus();
                }
            }
        }

        private void txarfolyam_TextChanged(object sender, EventArgs e)
        {
            if (txarfolyam.TextLength > 0)
            {
                try
                {
                    double szam = Convert.ToDouble(txarfolyam.Text);
                }
                catch
                {
                    MessageBox.Show("Arfolyamnak tört számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txarfolyam.Clear();
                    txarfolyam.Focus();
                }
            }
        }
    }
}
