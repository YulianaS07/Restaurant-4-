using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WseiLab4
{
    [Serializable]
    public class Zamowienie
    {
        public int NrStolika { get; set; }
        public string CoZostaloZamowione { get; set; }
        public decimal Cena { get; set; }

    }
    
    [Serializable]
    public class ListaZamowien : IEnumerable<Zamowienie>
    {
        public List<Zamowienie> listaZamowien = new List<Zamowienie>();
        public ListaZamowien()
        { }

        public void Add(Zamowienie zamowienie)
        {
            listaZamowien.Add(zamowienie);
        }
        public void Remove(Zamowienie zamowienie)
        {
            listaZamowien.Remove(zamowienie);
        }
        public IEnumerator<Zamowienie> GetEnumerator()
        {
            return listaZamowien.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    [Serializable]
    public class ListaGotowychDan : IEnumerable<Zamowienie>
    {
        public List<Zamowienie> GotoweDania = new List<Zamowienie>();
        public ListaGotowychDan()
        { }
        public void Add(Zamowienie zamowienie)
        {
            GotoweDania.Add(zamowienie);
        }
        public IEnumerator<Zamowienie> GetEnumerator()
        {
            return GotoweDania.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
