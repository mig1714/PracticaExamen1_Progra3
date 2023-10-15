using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsReportes
    {
        static string condicionConsultar = "";

        public static void ConsultarCondicion()


        {
            Console.WriteLine("Digite la condición a buscar ");
            condicionConsultar = Console.ReadLine();
            for (int i = 0; i < ClsEstudiante.condicion.Length; i++)
            {
                if (ClsEstudiante.condicion[i].Equals(condicionConsultar))


                {
                    Console.Write("Cedula     ");
                    Console.Write("Nombre:     ");
                    Console.Write("Promedio:     ");
                    Console.WriteLine("Condición     ");
                    Console.WriteLine("====================================================");
                    Console.Write(ClsEstudiante.cedula[i] + "            ");
                    Console.Write(ClsEstudiante.nombre[i] + "          ");
                    Console.Write(ClsEstudiante.nota[i] + "          ");
                    Console.WriteLine(ClsEstudiante.condicion[i] + "          ");
                    Console.WriteLine("====================================================");



                }

            }


        }

        public static void ConsultarTodosLosDatos() 
        
        {

            Console.WriteLine("Datos Ingresados");
            Console.WriteLine("Cantidad de Registros: "+ClsEstudiante.cedula.Length);




            for (int i = 0; i < ClsEstudiante.condicion.Length; i++)
            {
                
                    Console.Write("Cedula     ");
                    Console.Write("Nombre:     ");
                    Console.Write("Promedio:     ");
                    Console.WriteLine("Condición     ");
                    Console.WriteLine("====================================================");
                    Console.Write(ClsEstudiante.cedula[i] + "            ");
                    Console.Write(ClsEstudiante.nombre[i] + "          ");
                    Console.Write(ClsEstudiante.nota[i] + "          ");
                    Console.WriteLine(ClsEstudiante.condicion[i] + "          ");
                    Console.WriteLine("====================================================");
                    


                

            }




        }

    }
}
