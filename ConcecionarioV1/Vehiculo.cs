using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcecionarioV1
{
    public class Vehiculo
    {
        // Constantes

        // Miembros Privados
        private string _marca;
        private string _modelo;
        // Constructores
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        // Propiedades
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                // TODO: Proporcionar seguridad y proteccion al miembro -> _marca

                _marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set 
            {
                // TODO: Proporcionar seguridad y proteccion al miembro -> _modelo
                _modelo = value; 
            }
        }
        // Metodos Publicos

        // Metodos Privados
    }
}
