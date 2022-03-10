using System;

namespace Po.Labki._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Ułamek 
    {
        public int Licznik { get; }

        public int Mianownik { get; }

        Ułamek()
        {
         
        }

        Ułamek(int licznik, int mianownik)
        {
            this.Mianownik = mianownik;
            this.Licznik = licznik;
        }

        Ułamek(Ułamek Ułamek)
        {
            this.Licznik = Ułamek.Licznik;
            this.Mianownik = Ułamek.Mianownik;
        }

        public override string ToString()
        {
            return Licznik.ToString(); + " / " + Mianownik.ToString()
        }
       
    }
}

