using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    public interface IRachunki
    {
        RachunkiModel Dodaj(RachunkiModel model, int IdKasjer);
        void Usun(int IdRachunku);
        List<RachunkiModel> GetRachunkiList();
        RachunkiModel GetRachunek(int IdRachunku);
    }
}
