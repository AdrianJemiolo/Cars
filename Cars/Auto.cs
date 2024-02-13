using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianJemiolo09._02
{
    internal class Auto
    {
        public string marka;
        public string rokProdukcji;
        public string kolor;
        public double przebieg;
        public int spalanie;
        public Auto(string m,string r, string k, double p , int s)
        {
            this.marka = m; 
            this.rokProdukcji = r;
            this.kolor = k; 
            this.przebieg = p;  
            this.spalanie = s;
        }
        public string Info()
        {
            return $"marka: {this.marka}, rocznik {this.rokProdukcji}, kolor: {this.kolor}, przebieg: {this.przebieg} km, spalanie(na 100 km) {this.spalanie}l";
        }
        public double obliczSpalanie(int przejechane)
        {
            double wynik = (this.spalanie * przejechane) / 100;
            return wynik;
        }
    }
}
