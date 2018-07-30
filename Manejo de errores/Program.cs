using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                // Este es el bloque de codigo que se evalua
                int y = 10;
                int x = 0;
                int res = y / x;
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                // Esto pasa solo si ocurre un error 
                // en tiempo de ejecución
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Esto pasa siempre
                Console.WriteLine("Esto pasa siempre");
            }
        }
    }
}
