using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Lekarze
    {
        // wybor lekarza
        public string doctorChoose(string String)
        {
            switch (String)
            {
                case "Dentysta":
                    return "Wybrałeś lekarza, Dentystę.";
                
                case "Fizjoterapeuta":
                    return "Wybrałeś lekarza, Fizjoterapeute.";
                
                case "Kardiolog":
                    return "Wybrałeś lekarza, Kardiologa.";  
                
                case "Ginekolog":
                    return "Wybrałeś lekarza, Ginekologa.";
                
               case "Urolog":
                    return "Wybrałeś lekarza, Urologa.";
               
               case "Okulista":
                    return "Wybrałeś lekarza, Okuliste.";
               
            }

            return "Nie obsługujemy jeszcze takiego lekarza!";
        }
        //wybor godziny
        public int hourChoose(int Int)
        {
            switch (Int)
            {
                case 8:
                    return 8;
                case 9:
                    return 9;
                case 10:
                    return 10;               
                case 11:
                    return 11;               
                case 12:
                    return 12;                
                case 13:
                    return 13;               
                case 14:
                    return 14;

            }
            return 0;
        }
        // wybor dnia
        public int dateChoose(int Int)
        {
            switch (Int)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                case 4:
                    return 4;               
                case 5:
                    return 5;               
                case 6:
                    return 6;                
                case 7:
                    return 7;               
                case 8:
                    return 8;

            }
            return 0;
        }
        
        

    }
}
