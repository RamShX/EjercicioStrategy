using Mascota.Domain.Interfaces;
using Mascota.Domain.Modelos;

namespace Mascota.Domain.Factory
{
    public class FactoryMascota
    {
        public static IEstrategiaPaseo CrearMascota(int tipoMascota)
        {
            switch (tipoMascota)
            {
                case 1:
                    return new Chihuahua();
                case 2:
                    return new Ladrador();
                case 3:
                    return new HuskySiberiano();
                default:
                    Console.WriteLine("Opcion no válida");
                    return null;
            }
        }
    }
}
