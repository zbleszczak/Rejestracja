using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Rejestracja
    {
         public void appointment ()
         {
             //klient
            Klient klient = new Klient();
            Console.Write("Podaj swoje imię ");
            klient.name = Console.ReadLine();
            Console.Write("Podaj swoje nazwisko ");
            klient.surname = Console.ReadLine();
            Console.Write("Podaj swój wiek ");
            klient.age = Console.ReadLine();
            Console.WriteLine("Czy jesteś ubezpieczony? Tak lub Nie");
            klient.healthInsurance = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pomocy jakiego doktora potrzebujesz? ");
            Console.WriteLine("Wybierz sposród wymienionych poniżej. ");
            Console.WriteLine("W celu wybrania lekarza napisz nazwę lekarza. np: Dentysta ");
            
             // wybór lekarza
            Lekarze lekarze = new Lekarze();
            Console.WriteLine("Dostępni lekarze:");
            Console.WriteLine("Dentysta, Kardiolog, Fizjoterapeuta, Urolog, Ginekolog, Dermatolog, Okulista ");
            string doctor = Console.ReadLine();
            string choosenDoctor = lekarze.doctorChoose(doctor);
            Console.WriteLine("Wybrałeś wizytę u: " + choosenDoctor);
            Console.Clear();
            
            // wybór dnia miesiąca 
            Console.WriteLine("Proszę wybrać odpowiedni dzień tego miesiąca. Dostępne dni na ten miesiąc: ");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            int date = Convert.ToInt32(Console.ReadLine());
            int dateChoose = lekarze.dateChoose(date);
            Console.Clear();
            
            // wybór godziny
            Console.WriteLine("Proszę wybrać odpowiednią godzinę. Proszę pisać pierwszą liczbę. ");
            Console.WriteLine("Jeśli wybieramy 8.00, proszę napisać 8. ");
            Console.WriteLine("8.00");
            Console.WriteLine("9.00");
            Console.WriteLine("10.00");
            Console.WriteLine("11.00");
            Console.WriteLine("12.00");
            Console.WriteLine("13.00");
            Console.WriteLine("14.00");
            int hour = Convert.ToInt32(Console.ReadLine());
            int hourChoose = lekarze.hourChoose(hour);
            Console.Clear();
            
            // wyświetlenie informacji 
            Console.WriteLine("Imie: " + klient.name);
            Console.WriteLine("Nazwisko: " + klient.surname);
            Console.WriteLine("Wiek: " + klient.age);
            Console.WriteLine("Ubezpieczony: " + klient.healthInsurance);
            Console.WriteLine("Doktor: " + choosenDoctor);
            Console.WriteLine("Dzień: " + dateChoose);
            Console.WriteLine("Godzina: " + hourChoose);
            Console.ReadKey();
            
        }

    }
}
