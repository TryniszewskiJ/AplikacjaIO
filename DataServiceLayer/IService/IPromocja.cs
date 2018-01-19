using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    public interface IPromocja
    {
        PromocjeModel Wprowadz(PromocjeModel model);
        List<PromocjeModel> GetPromocjaList();
        PromocjeModel Edycja(PromocjeModel model);
        bool Usun(int IdPromocji);
        PromocjeModel GetPromocje(int IdPromocji);
    }
}
