///////////////////////////////////////////////////////////
//  Kierownik.cs
//  Implementation of the Class Kierownik
//  Generated by Enterprise Architect
//  Created on:      22-Nov-2017 3:41:49 PM
//  Original author: grzes
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using DataServiceLayer.IService;
using DataServiceLayer.Models.App;
using DataBaseLayer;

namespace DataServiceLayer.Service
{

    public class Kierownik : IKierownik
    {

        protected char haslo;
        public char Imie;
        public char Nazwisko;
        public Promocja m_Promocja;

        public Kierownik()
        {

        }

        ~Kierownik()
        {

        }

        public void ObslugaRaportow()
        {

        }

        public void WprowadzPromocje()
        {

        }
        public LoginModel Autoruzacja(Models.View.LoginModel model)//autoryzacja
        {
            using (DataBase context = new DataBase())
            {
                var kierownik = context.Kierowniks.SingleOrDefault(c => c.Login == model.Login && c.haslo == model.Haslo);
                if (kierownik == null)
                    return null;
                return new LoginModel
                {
                    UzytkownikId = kierownik.kierownikID,
                    UzytkownikImie = kierownik.imie,
                    UzytkownikRola = "Kierownik"
                };
            }
        }
    }//end Kierownik
}