using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Perfil
{
    class Preguntas : Info ///en esta clase haremos preguntas a nuestro usuario 
    {


        public Preguntas()  ///Esto es el CONSTRUCTOR de la clase "Preguntas" 
        {                   ///Vamos a utilizar este contructor para invocar la clase 
            //no siempre hace falta ingresar algun comando dentro del constructor 
        }

        /// Funciones de Preguntas
        public void Pregunta_Nombre() 
        {
            Console.WriteLine("Por favor ingrese su nombre:");
            nombre = Console.ReadLine(); //aca usamos el dato "nombre" que viene de la clase "Info"
            Console.WriteLine("Por favor ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("----------¡Bienvenidos " + nombre + " " + apellido + "!----------");
        }   

        public void Pregunta_Color() ///haremos unas preguntas simples al usuario para cargar datos
        {
            Console.WriteLine("Ingrese su color preferido");
            color = Console.ReadLine();
        }

        public void Pregunta_Comida() 
        {
                Console.WriteLine("Seleccione una de las siguientes opciones de comidas: ");
                Console.WriteLine(" [1] --> TACOS");
                Console.WriteLine(" [2] --> HELADO");
                Console.WriteLine(" [3] --> ASADO");

            SOLO_NUMEROS(); //Una funcion que es usado para respuestas que involucren SOLO NUMEROS

            switch (seleccion)
            {
               
                case 1:
                    comida = Convert.ToString(COMIDAS.TACOS);
                    break;
                case 2:
                    comida = Convert.ToString(COMIDAS.HELADO);
                    break;
                case 3:
                    comida = Convert.ToString(COMIDAS.ASADO);
                    break;
                default:
                    Console.WriteLine("SIN SELECCION");
                    break;
            }

        }

        public void Preguntas_Edad()
        {
            Console.WriteLine("Ingrese su edad, sin letras o simbolos raros");
            seguirLoop = true;
            while (seguirLoop)  //lo metemos en este while para evitar errores
            {
                try
                {
                    edad = Convert.ToInt32(Console.ReadLine());
                    seguirLoop = false;     //si el usuario ingresa un valor numerico, saldra del loop
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: dije que debes ingresar un numero!");
                    seguirLoop = true;  //si el usuario ingresa un valor NO numerico, NO saldra del loop
                }
            }
        }



        /// esta funcion nos permite obligar al usuario a ingresar un sistema un valor NUMERICO 
        /// para evitar errores y fallas en nuestro algoritmo
        public void SOLO_NUMEROS()
        {
            seguirLoop = true;
            while (seguirLoop)  //lo metemos en este while para evitar errores
            {
                try
                {
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    seguirLoop = false;     //si el usuario ingresa un valor numerico, saldra del loop
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: dije que debes ingresar un numero!");
                    seguirLoop = true;  //si el usuario ingresa un valor NO numerico, NO saldra del loop
                }
            }
        }


        /// Esta funcion es para mostrar los datos de nuestro Usuario 
        public void MostrarDatos() 
        {
            Console.WriteLine("---------- DATOS DEL USUARIO ----------");
            Console.WriteLine("Nombre Completo: " + nombre + " "+  apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Comida Preferido: " + comida);
            Console.WriteLine("Color Preferido: " + color);
        }


        /// Esta funcion es para modificar un dato especifico de nuestro Usuario
        /// PROBLEMA: cuando un usuario decide modificar un dato, ese dato se modifica PERO se borran los datos que ya ingreso previamente
        
        public void Modificacion()
        {
            while (continuar == 1)
            {
                Console.WriteLine("¿Que Desea Cambiar?");
                Console.WriteLine("[1] ---> NOMBRE + APELLIDO");
                Console.WriteLine("[2] ---> COLOR");
                Console.WriteLine("[3] ---> COMIDA");
                Console.WriteLine("[4] ---> EDAD");
                Console.WriteLine("Presione cualquier numero si desea NO modificar nada");
                SOLO_NUMEROS();
                switch (seleccion)
                {
                    case 1:
                        Pregunta_Nombre();
                        break;
                    case 2:
                        Pregunta_Color();
                        break;
                    case 3:
                        Pregunta_Comida();
                        break;
                    case 4:
                        Preguntas_Edad();
                        break;
                    default:
                        Console.WriteLine("No se ha modificado nada");
                        break;
                }
                Console.WriteLine("Presine [0] si desea modificar algo mas, sino presione cualquier boton");
                SOLO_NUMEROS();
                if (seleccion != 0) { continuar = 0; }
            }
        }

        ///  un loop para continuar el mismo programa
        public int Continuar(out int continuar)
        {
            Console.WriteLine("Presine [0] si desea crear un perfil nuevo, sino presione cualquier numero para finalizar");
            SOLO_NUMEROS();
            if (seleccion == 0)
            {
                continuar = 0;
            }
            else
            {
                continuar = 1;
            }
            return continuar;
        }

    }
    
}
