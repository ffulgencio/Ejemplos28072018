using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    // Declaramos un tipo delegado
    // que pueda representar métodos
    // que no retornan valor ni reciben parametros
    delegate void DelVoid(); 
    //declaramos un delegado que retorna valor
    // y recibe un parametro
    delegate int DelIntRes(int x);

    class Program
    {
        static void Main(string[] args)
        {
            //Asignamos un metodo anonimo al delegado
            DelVoid dv = delegate ()
            {
                Console.WriteLine("Soy un metodo Anonimo");
            };

            // Agregamos el metodo saludar al mismo delegado
            dv += Saludar;

            dv(); // llamada al delegado

            // Asignamos un metodo anonimo que retorna valor
            //y recibe parametros
            DelIntRes dir = delegate(int b)
            {
                return b * b; // b al cuadrado
            };

            // Agregamos el metodo duplicar a ese
            dir += Duplicar;

            Console.WriteLine(dir(5));
        }

        static void Display()
        {
            Console.WriteLine("Hola Mundo");
        }

        static void Saludar()
        {
            Console.WriteLine("Hola");
        }

        static int Duplicar(int a)
        {
            return a * 2;
        }
    }
}
