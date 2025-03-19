using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Modelos
{
    public class Ladrador : IEstrategiaPaseo
    {
        public void PasearMascota()
        {
            Console.WriteLine("LABRADOR: 40 MINUTOS. COSTO: RD$200");
        }
    }
}
