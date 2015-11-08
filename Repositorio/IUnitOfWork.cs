using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    interface IUnitOfWork : IDisposable
    {
        IUsuariosRepositorio Usuarios { get; }
    }
}
