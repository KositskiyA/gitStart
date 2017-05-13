using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokuments
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Dokument tipa *.XML izmenen");
        }

        public override void Create()
        {
            Console.WriteLine("Dokument tipa *.XML sozdan");
        }

        public override void Open()
        {
            Console.WriteLine("otkrit dokument *.XML");
        }

        public override void Save()
        {
            Console.WriteLine("Dokument tipa *.XML sohranen");
        }
    }
}
