using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasDaoLibrary.Interface
{
    public interface ICRUD<T>
    {
        List<T> ListaTodos();
        T leerPorId(int id);
        void registrar(T persona);
        void actualizar(T persona);
        void eliminar(int id);
    }
}
