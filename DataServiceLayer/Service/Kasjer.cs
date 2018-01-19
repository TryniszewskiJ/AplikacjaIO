///////////////////////////////////////////////////////////
//  Kasjer.cs
//  Implementation of the Class Kasjer
//  Generated by Enterprise Architect
//  Created on:      22-Nov-2017 3:41:38 PM
//  Original author: grzes
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using DataServiceLayer.IService;
using DataServiceLayer.Models;
using DataServiceLayer.Models.App;
using DataBaseLayer;

namespace DataServiceLayer.Service
{
    public class Kasjer : IKasjer
    {

        protected int haslo;
        private int id_kasjera;
        public char Imie;
        public char nazwisko;

        public Kasjer()
        {

        }

        ~Kasjer()
        {

        }

        public void AktywacjaRabatu()
        {

        }

        public void ObslugaRachunku()
        {

        }

        public LoginModel Autoruzacja(Models.View.LoginModel model)//autoryzacja
        {
            using (DataBase context = new DataBase())
            {
                var kasjer = context.Kasjers.SingleOrDefault(c => c.Login == model.Login && c.haslo == model.Haslo);
                if (kasjer == null)
                    return null;
                return new LoginModel
                {
                    UzytkownikId = kasjer.kasjerID,
                    UzytkownikImie = kasjer.imie,
                    UzytkownikRola = "Kasjer"
                };
            }
        }

    }//end Kasjer
}