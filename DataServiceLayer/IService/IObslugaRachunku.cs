using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer.IService
{
    interface IObslugaRachunku
    {
        void EdytujRachunek();
        void OtworzRachunek();
        void ZamknijRachunek();
    }
}
