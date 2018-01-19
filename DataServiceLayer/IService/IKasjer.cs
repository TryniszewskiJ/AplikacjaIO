using DataServiceLayer.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    public interface IKasjer
    {
        void AktywacjaRabatu();
        void ObslugaRachunku();
        LoginModel Autoruzacja(Models.View.LoginModel model);
    }
}
