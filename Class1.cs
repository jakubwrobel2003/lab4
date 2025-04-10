

namespace Geometria

{
    public abstract class Bryła
    {
        private string nazwa;
        private double gestosc;
        private double cenaZaKg;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }
        public double Gestosc => gestosc;
        public double CenaZaKg => cenaZaKg;

        public abstract double ObliczObj();
        public double ObliczMase() {
            return ObliczObj() * this.gestosc;
        }
        public  double ObliczCene()
        {
            return ObliczObj() * this.cenaZaKg;
        }


        public Bryła(string n, double g, double c)
        {
            this.nazwa = n;
            this.gestosc = g;
            this.cenaZaKg = c;
        }
        public override string ToString()
        {
            return $"Nazwa: {nazwa}, Gęstość: {gestosc}, Cena za kg: {cenaZaKg} Objetosc: {ObliczObj()} Masa  {ObliczMase()}  cena  {ObliczCene()} ";

        }
    }
    public class Kula:Bryła{
        private double promien;
        public double Promien=> promien;



        public override double ObliczObj()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(promien, 3);
        }
        
        public  Kula(double p, double g, double c) : base("KULA",g,c)
        {
            this.promien = p;
            
        }
    }
    public class Stozek:Kula
    {
       
        
        private double h;
        public double H => h;

        public override double ObliczObj()
        {
            return 1.0 / 3.0 * Math.PI * Math.Pow(this.Promien, 2)*h;
        }

        public Stozek(double e,double p, double g, double c) : base(p, g, c)
        {
            this.h = e;
            this.Nazwa = "Stozek";

        }
    }
     
}
namespace rozszezenie
{
    public interface IWyświetl
    {
        string PobierzIdentyfikator();

    }
    public static class ListBoxExtensions
    {

        public static void Dodaj(this ListBox listBox, IWyświetl obiekt)
        {
            listBox.Items.Add(obiekt.PobierzIdentyfikator());
        }
    }
}
