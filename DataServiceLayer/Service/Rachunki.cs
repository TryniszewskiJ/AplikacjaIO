///////////////////////////////////////////////////////////
//  ObsługaRachunku.cs
//  Implementation of the Class ObsługaRachunku
//  Generated by Enterprise Architect
//  Created on:      22-Nov-2017 3:41:26 PM
//  Original author: grzes
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using DataBaseLayer;
using System.Linq;

namespace DataServiceLayer.Service
{
    public class Rachunki : IRachunki
    {
        RachunkiModel Dodaj(RachunkiModel model,int IdKasjer)
        {
            using (DataBase context = new DataBase())
            {
                DataBaseLayer.Rachunki rachunek = new DataBaseLayer.Rachunki
                {
                    DataRachunku = DateTime.Now,
                    kasjerID = IdKasjer,
                    Kasjer = context.Kasjers.SingleOrDefault(c => c.kasjerID == IdKasjer),
                    wysokoscRachunku = model.Wysokosc,
                    PozycjeNaRachunkus = new List<PozycjeNaRachunku>(),
                };
                foreach(var pozycja in model.Sklad)
                {
                    rachunek.PozycjeNaRachunkus.Add(new PozycjeNaRachunku
                    {
                        Cena = pozycja.Cena,
                        Ilosc = pozycja.Ilosc,
                        Rachunki = rachunek,
                        IdRachunku = rachunek.IdRachunku
                    });
                }
            }
            return model;
        }

        public void Usun(int IdRachunku)
        {

        }

        public List<RachunkiModel> GetRachunkiList()
        {
            using (DataBase context = new DataBase())
            {
                var rachunki = context.Rachunkis.ToList();
                List<RachunkiModel> toList = new List<RachunkiModel>();
                foreach (var rachunek in rachunki)
                {
                    toList.Add(new RachunkiModel
                    {
                        IdKasjera = rachunek.kasjerID.Value,
                        IdRachunku = rachunek.IdRachunku,
                        Wysokosc = rachunek.wysokoscRachunku.Value,
                        Sklad = null
                    });
                }
                return toList;
            }
        }

    }//end ObsługaRachunku
}