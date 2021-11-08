using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Perfil
{
    abstract class Info ///en esta clase registramos toda la info que nos brinda el usuario
    // declaramos esta clase como "abstract" debido que solo lo usamos para registrar datos, que luego seran invocados y utilizado
    //en la clase hija que declaramos como "Preguntas" luego, creamos objetos de la clase "Preguntas"
    //NO OLVIDAR: las clases de tipo "abstract" NO PUEDEN CONSTRUIR OBJETOS
    {
        /// datos que registramos del usuario
        public string nombre;
        public string apellido;
        public int edad;
        public string comida;
        public enum COMIDAS { TACOS, HELADO, ASADO };
        public string color;

        /// Datos que vamos a utliziar en la clase "Preguntas" para no crear valores repetidos inecesarios
        public bool seguirLoop; //utilizamos esto para los while
        public int seleccion;   //usaremos esto para los switch 
        public int continuar = 1;

        






    }
}
