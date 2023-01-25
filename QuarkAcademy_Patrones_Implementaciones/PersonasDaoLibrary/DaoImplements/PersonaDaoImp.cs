using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasDaoLibrary.Interface;
using PersonasDaoLibrary.Model;

namespace PersonasDaoLibrary.DaoImplements
{
    public class PersonaDaoImp : IPersonaDao
    {
        private Iconexiones conexion;
        private List<Persona> listPersonas;

        public PersonaDaoImp(Iconexiones conn)
        {
            this.conexion = conn;
            listPersonas = new List<Persona>();
            listPersonas.Add(new Persona("pablo","taddei",1));
            listPersonas.Add(new Persona("alejandro","djdjdj", 2));
            listPersonas.Add(new Persona("estevan","quito",3));
            listPersonas.Add(new Persona("sdsd","asdasd",4));
            listPersonas.Add(new Persona("sadfsdf", "asdasdf", 5));
            listPersonas.Add(new Persona("asdasdf", "adsasdf", 6));
            listPersonas.Add(new Persona("sadfasf", "ererer", 7));
            listPersonas.Add(new Persona("okokoko", "iuhiuhiuhi", 8));
            listPersonas.Add(new Persona("kkjsjjsueuuey", "jjjffyettetst", 9));
        }

        public void actualizar(Persona persona)
        {
            for (int index = 0; index < listPersonas.Count; index++)
            {
                if (listPersonas[index].Id == persona.Id)
                {
                    listPersonas[index] = persona;
                }
            }
        }

        public void eliminar(int id)
        {
            foreach (Persona item in listPersonas)
            {
                if (item.Id == id)
                {
                    listPersonas.Remove(item);
                    break;
                }
            }
        }

        public Persona leerPorId(int id)
        {
            Persona person = new Persona();
            foreach (Persona item in listPersonas)
            {
                if (item.Id == id)
                {
                    person = item;
                }
            }
            return person;
        }

        public List<Persona> ListaTodos()
        {
            return listPersonas;
        }

        public void registrar(Persona persona)
        {
            listPersonas.Add(persona);
        }
    }
}
