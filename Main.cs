using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
     class Constructor
        {
            static void Main(string[] args)
            {
            Console.Title = "Ejemplo de herencia";
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
			DatosDeEmpleado empleado = new DatosDeEmpleado("José","Medina", "189-34-2320",3500.00M,.07M);
         Console.ReadLine();
               
            }
        }
    }
     
