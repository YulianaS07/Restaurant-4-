using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WseiLab4
{
    public partial class Form1 : Form
    {
        ListaZamowien _listaZamowien = new ListaZamowien();
        ListaGotowychDan _listaGotowychDan = new ListaGotowychDan();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\serializacja\lista.xml"))
            {
                using (FileStream fs = new FileStream(@"D:\serializacja\lista.xml", FileMode.Open))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(ListaZamowien));
                    ListaZamowien listaZamowien = (ListaZamowien)formatter.Deserialize(fs);
                    foreach (Zamowienie zamowienie in listaZamowien)
                    {
                        listBoxKuchnia.Items.Add($"Numer stolika: {zamowienie.NrStolika}, zamówienie: {zamowienie.CoZostaloZamowione}, cena: {zamowienie.Cena} zł");
                    }
                }
            }
            if (File.Exists(@"D:\serializacja\gotowe_dania.xml"))
            {
                using (FileStream fs = new FileStream(@"D:\serializacja\gotowe_dania.xml", FileMode.Open))
                {
                    XmlSerializer formatterGotoweDania = new XmlSerializer(typeof(ListaGotowychDan));
                    ListaGotowychDan listaGotowychDan = (ListaGotowychDan)formatterGotoweDania.Deserialize(fs);
                    foreach (Zamowienie zamowienie in listaGotowychDan)
                    {
                        listBoxGotoweDania.Items.Add($"Numer stolika: {zamowienie.NrStolika}, zamówienie: {zamowienie.CoZostaloZamowione}, cena: {zamowienie.Cena} zł");
                    }
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(@"D:\serializacja\lista.xml", FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ListaZamowien));
                ListaZamowien listaZamowien = new ListaZamowien();

                foreach (var item in listBoxKuchnia.Items)
                {
                    string linia = item.ToString();
                    string[] czesci = linia.Split(',');

                    int nrStolika = int.Parse(czesci[0].Split(':')[1].Trim());
                    string coZostaloZamowione = czesci[1].Split(':')[1].Trim();
                    decimal cena = decimal.Parse(czesci[2].Split(':')[1].Trim().Split(' ')[0]);
                    Zamowienie noweZamowienie = new Zamowienie
                    {
                        NrStolika = nrStolika,
                        CoZostaloZamowione = coZostaloZamowione,
                        Cena = cena
                    };
                    listaZamowien.Add(noweZamowienie);
                }

                formatter.Serialize(fs, listaZamowien);
            }
            using (FileStream fs = new FileStream(@"D:\serializacja\gotowe_dania.xml", FileMode.Create))
            {
                XmlSerializer formatterGotoweDania = new XmlSerializer(typeof(ListaGotowychDan));
                ListaGotowychDan listaGotowychDan = new ListaGotowychDan();

                foreach (var item in listBoxGotoweDania.Items)
                {
                    string linia = item.ToString();
                    string[] czesci = linia.Split(',');

                    int nrStolika = int.Parse(czesci[0].Split(':')[1].Trim());
                    string coZostaloZamowione = czesci[1].Split(':')[1].Trim();
                    decimal cena = decimal.Parse(czesci[2].Split(':')[1].Trim().Split(' ')[0]);
                    Zamowienie noweZamowienie = new Zamowienie
                    {
                        NrStolika = nrStolika,
                        CoZostaloZamowione = coZostaloZamowione,
                        Cena = cena
                    };
                    listaGotowychDan.Add(noweZamowienie);
                }

                formatterGotoweDania.Serialize(fs, listaGotowychDan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamowienie zamowienie = new Zamowienie();
            zamowienie.NrStolika = int.Parse(dataInNrStolika.Text);
            zamowienie.CoZostaloZamowione = dataInZamowienie.Text;
            zamowienie.Cena = decimal.Parse(dataInCena.Text);

            _listaZamowien.Add(zamowienie);
            _listaGotowychDan.Add(zamowienie);
            listBoxKuchnia.Items.Clear();
            foreach (Zamowienie _zamowienie in _listaZamowien)
            {
                listBoxKuchnia.Items.Add($"Numer stolika: {_zamowienie.NrStolika}, zamówienie: {_zamowienie.CoZostaloZamowione}, cena: {_zamowienie.Cena} zł");
            }

            dataInCena.Clear();
            dataInNrStolika.Clear();
            dataInZamowienie.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
                string wybranaLinia = listBoxKuchnia.SelectedItem.ToString();
                string[] czesci = wybranaLinia.Split(',');

                int nrStolika = int.Parse(czesci[0].Split(':')[1].Trim());
                string coZostaloZamowione = czesci[1].Split(':')[1].Trim();
                decimal cena = decimal.Parse(czesci[2].Split(':')[1].Trim().Split(' ')[0]);

                Zamowienie wybraneZamowienie = new Zamowienie
                {
                    NrStolika = nrStolika,
                    CoZostaloZamowione = coZostaloZamowione,
                    Cena = cena
                };
                _listaGotowychDan.Add(wybraneZamowienie);
                foreach (Zamowienie _zamowienie in _listaGotowychDan)
                {
                    listBoxGotoweDania.Items.Add($"Numer stolika: {_zamowienie.NrStolika}, zamówienie: {_zamowienie.CoZostaloZamowione}, cena: {_zamowienie.Cena} zł");
                }
                listBoxKuchnia.Items.Remove(wybranaLinia);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string wybranaLinia = listBoxGotoweDania.SelectedItem.ToString();
            listBoxGotoweDania.Items.Remove(wybranaLinia);
        }
    }
}