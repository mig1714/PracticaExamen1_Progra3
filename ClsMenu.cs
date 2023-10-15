using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsMenu
    {

        static bool bandera = true;
        static int opcion = 0;

        public void Desplegar() 
        
        {
            do
            {
                Console.WriteLine("1-Inicializar");
                Console.WriteLine("2-Incluir");
                Console.WriteLine("3-Modificar");
                Console.WriteLine("4-Mostrar");
                Console.WriteLine("5-Eliminar");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7-Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion == 7) {
                    bandera = false;
                    break;
                }

                switch (opcion) 
                
                {

                    case 1: ClsEstudiante.Inicializar(); break;
                    case 2: ClsEstudiante.Incluir(); break;
                    case 3: ClsEstudiante.Modificar(); break;

                    case 4: ClsEstudiante.Consultar(); break;
                    case 5: ClsEstudiante.Eliminar(); break;

                    case 6: ClsMenuReportes.DesplegarSubmenu() ; break;




                }

            


            }while (bandera);
        }


        
    }
}
