using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.DI.Interfaces
{
    public interface IAutomovelService
    {
        string RealizarEntrega(string tipoEntrega);
    }
}
