﻿namespace CSharp2_BrekOutRoom_Lekce6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
            //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
            //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
            //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
            //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

            Obdelnik prvniObdelnik = new Obdelnik(12, 24);
            Obdelnik druhyObdelnik = new Obdelnik(3, 50);
            Obdelnik tretiObdelnik = new Obdelnik(14);

            prvniObdelnik.VypisInformace();
            druhyObdelnik.VypisInformace();
            tretiObdelnik.VypisInformace();
        }


    }
}

