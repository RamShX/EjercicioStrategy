using Mascota.Domain.Contexto;
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
                int opcion = Convert.ToInt32(Console.ReadLine());

                PaseadorMascota pM = null;
                switch (opcion)
                {
                    case 1:
                        Chiguagua chiguagua = new Chiguagua();
                        pM = new PaseadorMascota(chiguagua);
                        break;
                    case 2:
                        Ladrador ladrador = new Ladrador();
                        pM = new PaseadorMascota(ladrador);
                        break;
                    case 3:
                        HuskySiberiano huskySiberiano = new HuskySiberiano();
                        pM = new PaseadorMascota(huskySiberiano);
                        break;
                    case 4:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                pM.PasearMascota();
                Console.WriteLine("Presione para seguir...");
                Console.ReadKey();


            }
        }
    }
}
