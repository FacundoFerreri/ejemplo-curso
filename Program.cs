using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //clases, Objetos, Propiedades y Encapsulamiento.

            //Persona: Edad, Sueldo, Nombre.
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //Persona p1 = new Persona("PEPE");
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar()); //es un compotaminto de la persona
            //Console.WriteLine(p1.saludar(" MAXI ")); // sobrecarga del metodo
            //Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plástico");  //objeto con el consructor con valores. Se cargan por primera y única vez y luego no se pueden modificar.

            //b1.Capacidad = 200;   //eso va a ir a la propiedad "capacidad" de la clase botella, capturar ese valor que le estoy dando en el value genérico, lo va a asignar a la variable int capacidad)
            //string algo2 = b1.material;  //por como lo construí, el atributo material solo puede leerse.
            //int algo = b1.Capacidad; // para leer el valor de capacidad y asignar su contenido a otra variable.

            //Botella b2 = new Botella() { }  // objeto con el consructor vacío - sobrecarga

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es:" + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es:" + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es:" + b1.CantidadActual);

            //Perro pe1 = new Perro();
            //pe1.Color = 15;

            //int algo2 = pe1.Color;

            //Console.WriteLine("El color del perro es  " + pe1.Color);

            Console.ReadKey();

        }
    }
}
