using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Botella
    {
        //capacidad máxima: 100
        //cantidadActual: inicia en cero.
        //método recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100.
         
        public Botella(string color, string material)  // constuctor creado por mi (esto hace que se pise el heredado de la clase object)
        {
            this.color = color;   //this. Puntero que hace referencia a la clase. A mi color asigname el color que vino por parámetro.
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        // sobrecargar el constructor
        public Botella() { }//no recibe parámetros y no tiene lógica. Paa poder usar la clase botella sindatos iniciales

        // ~Botella() destructor
        //    {}

        //Botella: Capacidad, Color, Material.
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad;}

        }

        public int CantidadActual
        {
            get { return cantidadActual;}
        }
        public string Material
        {
            get { return material; }
        }

        //PROPIEDAD: exclusivo de C#. pseudo función.
        //public int Capacidad
        //{
        //   get { return capacidad; }   //devolución del valor
        //    set { capacidad = value; }  //recepción de ese valor y su posterior asignación en el atributo privado

        //Método
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                // 100 50
                //dif 
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            else
            {
                cantidadActual = 100;
                return 50;
            }

         }    
            public float recargar(int cantidad)
               {
                 cantidadActual += cantidad;
                 return cantidad * 50 / 100;
               }


        }

        }


   
