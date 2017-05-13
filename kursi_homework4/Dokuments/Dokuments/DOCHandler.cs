using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokuments
{
    class DOCHandler:AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Dokument tipa *.doc izmenen");
        }

        public override void Create()
        {
            Console.WriteLine("Dokument tipa *.doc sozdan");
        }

        public override void Open()
        {
            Console.WriteLine("otkrit dokument *.doc");
        }

        public override void Save()
        {
            Console.WriteLine("Dokument tipa *.doc sohranen");
        }
    }
}
