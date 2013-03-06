using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Datos_usuario
    {
        static void Main(string[] args)
        {
            string nombre, facebook, direccion;
            int años, cel;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Que tal {0}, cual es tu Direccion en la cual vives recientemente?", nombre);
            direccion = Console.ReadLine();
            Console.WriteLine("{0}, cual es tu numero telefonico?", nombre);
            cel = int.Parse(System.Console.ReadLine());
            Console.WriteLine("{0}, cual es tu cuenta de Facebook?", nombre);
            facebook = Console.ReadLine();
            Console.WriteLine("{0}, que edad tienes?", nombre);
            años = int.Parse(System.Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0} tienes {1} años y tu direccion es: {2} tu telefono es: {3} y tu facebook es: {4}", nombre, años, direccion, cel, facebook);
            Console.Read();
        }
    }
}