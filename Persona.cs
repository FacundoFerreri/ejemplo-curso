using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUOS o MIEMBROS - Variables que nos van a permitir guardar la información de esa persona.
        // Los atributos deben cuplir ciertas características:
        // El ENCAPSULAMIENTO: Un miembro de una clase no tendría que poder ser accedido desde el exterior.

        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;

        }

        public int getEdad()
        {   // función para leer la edad de la persona

            return edad;

        }

        //MODIFICADORES DE VISIBILIDAD: Son palabras reservadas que nos permiten calificar un atributo
        // una función, como: PRIVADO, PUBLICO, INTERNAL. PROTEGIDO.
        // PUBLICO: Vamos a tener full acceso desde oros elementos.
        // PRIVADO: No vamos a tener acceso desde oros elementos. palabra reserada PRIVATE

        //MÉTODOS - compotamiento del objeto.
        // Saludar, decir mi edad, a partir de información que yo tengo guadada en mi objeto.
        public string saludar()    // metodo saludar
        {
            return "Hola soy ..." + nombre;
        }

        public string saludar(string personaje)   //sobrecarga del método
        {
            return "Hola" + personaje + ", soy ..." + nombre;
        }
    }

}
