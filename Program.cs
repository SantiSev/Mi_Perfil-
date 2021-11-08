using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Perfil
{
    class Program ///en esta clase corremos nuestro algoritmo
    {
        static void Main(string[] args)
        {
            int continuar = 0; //es un valor que comienza en 0 pero luego varia entre 1 o 0 para definir la continuidad del programa 
            while (continuar == 0)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Crearemos tu propio usuario");
                Console.WriteLine("---------------------------");
                Console.WriteLine(" ");
                Preguntas P = new Preguntas();
                Preguntas();
                Console.WriteLine(" ");
                Console.WriteLine("-----SETTINGS-----");
                Console.WriteLine("[0] ---> NO MODIFICAR");
                Console.WriteLine("[1] ---> EDITAR UN DATO");
                Console.WriteLine("[2] ---> BORRAR TODO LOS DATOS");  //esta funcion todavia no esta implementado, 
                Console.WriteLine(" ");
                int Cambio = Convert.ToInt32(Console.ReadLine());
                switch (Cambio) 
                {
                    case 0:
                        break;
                    case 1:
                        P.Modificacion();
     
                        break;
                    case 2:
                        ///en el caso de haber un "BORRAR TODO LOS DATOS" lo iba a realizar a traves de un 
                        ///"override" de Mostrar datos que anule todo los valores pero no me salio muy bien implementarlo todavia 
                        break;
                }
                
                P.Continuar(out continuar); //esto permitira al usuario continuar en el programa o no
            }
            Console.WriteLine("GoodBye");
         
            Console.ReadKey();
        }



        /// La funcion que ejecuta todas las preguntas  y muestra los datos que ingresaste
        static void Preguntas() 
        {
            Preguntas P = new Preguntas(); //creamos el objeto "Preguntas", en otras palabras, invocamos la clase "Preguntas"
            P.Pregunta_Nombre();
            Console.WriteLine(" ");
            P.Preguntas_Edad();
            Console.WriteLine(" ");
            P.Pregunta_Color();
            Console.WriteLine(" ");
            P.Pregunta_Comida();
            Console.WriteLine(" ");
            P.MostrarDatos();
        }


    }
}
