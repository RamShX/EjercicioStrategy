using Mascota.Domain.Contexto;
using Mascota.Domain.Factory;
using Mascota.Domain.Interfaces;
using Mascota.Domain.Modelos;

namespace Mascota.Gui
{
    public class InstanciaApp
    {
        public void Funcionalidad()
        {
           
            bool exit = true;


            while (exit)
            {
                Console.Clear();
                Console.WriteLine("Paseo de mascosta");
                Console.WriteLine("[1] Chiguagua");
                Console.WriteLine("[2] Ladrador");
                Console.WriteLine("[3] Husky siberiano");
                Console.WriteLine("[4] Salir");
                Console.WriteLine("Elija una opción para saber más detalle");
                

                if(!int.TryParse(Console.ReadLine(), out int option ) || option < 1 || option > 4) 
                {
                    Console.WriteLine("Opción no válida");
                    Console.WriteLine("Presione para seguir...");
                    Console.ReadKey();
                    continue;
                }

                if (option == 4)
                {
                    exit = false;
                    continue;
                }

                IEstrategiaPaseo estrategia = FactoryMascota.CrearMascota(option);

                if (estrategia != null) 
                {
                    PaseadorMascota pM = new PaseadorMascota(estrategia);
                    pM.PasearMascota();
                }
               

                Console.WriteLine("Presione para seguir...");
                Console.ReadKey();


            }
        }
    }
}
