using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokuments
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();
    }
}
