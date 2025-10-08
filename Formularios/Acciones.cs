using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    internal class Acciones
    {
        private List<string>listanombres = new List<string>();

        public List<string>ObtenerNombre()
        { 
          return listanombres; 
        }

        public bool AgregarNombres (string nombre)
        {
            try
            {
                listanombres.Add(nombre);
                return true;
            }
            catch(Exception) 
            {
                return false;
            }
        }
        public bool EliminarNombre (string nombre) 
        {
            try
            {
                if (listanombres.Remove(nombre))
                {
                    listanombres.Remove(nombre);
                    return true;
                }
                else
                {         
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
