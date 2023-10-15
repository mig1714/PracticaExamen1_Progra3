using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClsMenuReportes
    {
        static int opcionSubMenu = 0;
        static bool banderaMenu = true;


        public static void DesplegarSubmenu() 
        
        {
            Console.WriteLine("MENÚ DE REPORTES");

            do
            {


                Console.WriteLine("1-Reporte por condición");
                Console.WriteLine("2-Mostrar todos los registro");
                Console.WriteLine("3-Volver al menu principal");
                int.TryParse(Console.ReadLine(), out opcionSubMenu);
                if (opcionSubMenu == 3)
                {
                    ClsMenu menu = new ClsMenu();
                    menu.Desplegar();
                    banderaMenu = false;
                }

                switch (opcionSubMenu) 
                    
                    {

                        case 1: ClsReportes.ConsultarCondicion(); break;
                        case 2: ClsReportes.ConsultarTodosLosDatos(); break;
                    
                    }
                
            } while (banderaMenu);

        }


    }

     

  }

