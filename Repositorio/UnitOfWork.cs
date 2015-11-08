using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly UsuariosDataContext _context;

        public UnitOfWork(UsuariosDataContext context)
        {
            _context = context;
        }

        public IUsuariosRepositorio Usuarios {get; set;}

        public void Complete(){
             _context.SubmitChanges();
        }

        public void Dispose(){

            _context.Dispose();
        }
    }
}
