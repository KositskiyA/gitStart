using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokuments
{
    class Program1
    {
        AbstractHandler AH;

        public Program1(AbstractHandler newDocument)
        {
            this.AH = newDocument;
        }
        static void Main(string[] args)
        {

            Program1 pr1 = new Program1(new DOCHandler());
            pr1.AH.Open();
            pr1.AH.Create();
            pr1.AH.Chenge();
            pr1.AH.Save();
            Console.ReadKey();

        }

    }
}
