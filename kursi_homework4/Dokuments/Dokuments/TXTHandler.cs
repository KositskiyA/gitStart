using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokuments
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Dokument tipa *.txt izmenen");
        }

        public override void Create()
        {
            Console.WriteLine("Dokument tipa *.txt sozdan");
        }

        public override void Open()
        {
            Console.WriteLine("otkrit dokument *.txt");
        }

        public override void Save()
        {
            Console.WriteLine("Dokument tipa *.txt sohranen");
        }
    }
}
