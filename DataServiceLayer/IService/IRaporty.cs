using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    public interface IRaporty
    {
        RaportModel GetRaport(int IdRaportu);
        List<RaportModel> GetRaportList();
        RaportModel Utworz(RaportModel model);
        void Usun(int IdRaportu);
        void Edytuj();
    }
}
