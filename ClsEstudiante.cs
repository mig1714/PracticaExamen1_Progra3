using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsEstudiante
    {

        //public string cedula { get; set; }
        static int cantidad = cantidad;

        static string cedulaConsultar = "";

        static string condicionModicar = "";
        public static string[] cedula = new string[cantidad];
        //public string nombre { get; set; }

        public static string[] nombre = new string[cantidad];
        //public float nota { get; set; }
        public static float[] nota = new float[cantidad];

        public static string[] condicion= new string[cantidad];

        public static void Inicializar()
        {
            Console.WriteLine("Ingrese la cantidad de alumunos: ");
            int.TryParse(Console.ReadLine(), out cantidad);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Cedula lenght: " + cedula.Length);
            /*for (int i = 0; i < cantidad; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                nota[i] = 0f;

            }*/
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            nota = Enumerable.Repeat(0f, cantidad).ToArray();
            condicion =Enumerable.Repeat("", cantidad).ToArray() ;





        }
        public static void Incluir() 
        {

            Console.WriteLine("Cantidad de Alumnos: "+cantidad);
            for (int i = 0; i < cantidad; i++)
                
            {
                

                Console.WriteLine("Ingrese la cedula: ");
                cedula[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre: ");
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la nota: ");
                float.TryParse(Console.ReadLine(), out nota[i]);

                Console.WriteLine("Nota a evaluar: " + nota[i]);

                if (nota[i] >= 70f)
                {
                    condicion[i] = "Aprobado";

                }
                else if (nota[i] >= 60 && nota[i] < 70)
                {
                    condicion[i] = "Aplazado"; 
                }
                else if (nota[i]> 0 && nota[i]< 60) 
                {
                    condicion[i] = "Reprobado";
                    
                
                }

               




            }

        }




        
        public static void Consultar()
         
        
        {
            Console.WriteLine("Digite la cedula a buscar: ");
            cedulaConsultar = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Equals(cedulaConsultar))


                {
                    Console.Write("Cedula     ");
                    Console.Write("Nombre:     "  );
                    Console.Write("Promedio:     " );
                    Console.WriteLine("Condición     "  );
                    Console.WriteLine("====================================================");
                    Console.Write(cedula[i]+"            ");
                    Console.Write(nombre[i] + "          ");
                    Console.Write(nota[i] + "          ");
                    Console.WriteLine(condicion[i] + "          ");
                    Console.WriteLine("====================================================");



                }
               
            }


        }
        public static void Modificar() 
        {

            Console.WriteLine("Digite la cedula a buscar: ");
            cedulaConsultar = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Equals(cedulaConsultar))
                {

                    Console.WriteLine("Ingrese el nombre: ");
                    nombre[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese la nota: ");
                    float.TryParse(Console.ReadLine(), out nota[i]);

                    Console.WriteLine("Condición: ");
                    condicion[i] = Console.ReadLine();
                    


                }

            }
            Console.WriteLine("Registro Modificado");


        }
    

        public static void Eliminar() 
        {

            Console.WriteLine("Digite la cedula a buscar: ");
            cedulaConsultar = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Equals(cedulaConsultar))
                {
                    
                    nombre[i] = "";
                    nota[i] = 0f;

                }

            }
            Console.WriteLine("Registro Eliminado");


        }
    }
}
