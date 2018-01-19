using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    interface IObslugaRaportow
    {
        void EdytujRaport();
        void PrzegladajRaport();
        void StworzRaport();
        void UsunRaport();
    }
}
