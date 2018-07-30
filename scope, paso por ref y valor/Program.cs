using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static int global = 10; //global

        static void Main(string[] args)
        {
            Persona p = new Persona(); // local
            p.Nombre = "Juan";
            int x = 10; // local
            Saludar(p);
            Console.WriteLine($"Fuera del método la variable nombre vale {p.Nombre}");
            Duplicar(ref x);
            Console.WriteLine($"Fuera del metodo X vale {x}");
        }

        static void Saludar( Persona persona)
        {
            persona.Nombre +="*";
            Console.WriteLine("Hola "+ persona.Nombre);
        }

        static void Duplicar(ref int y)
        {
            y = y * 2;
            Console.WriteLine($"Dentro del metodo y vale {y}");
        }
    }

    // Las instancias de una estructura pasan por valor
    struct Persona
    {
        public string Nombre;
    }

    // Las instancias de una clase pasan por valor
    class Persona2
    {
        public string Nombre;
    }
}
