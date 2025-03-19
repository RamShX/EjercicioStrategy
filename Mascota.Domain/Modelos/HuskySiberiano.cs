using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Modelos
{
    public class HuskySiberiano : IEstrategiaPaseo
    {
        public void PasearMascota()
        {
            Console.WriteLine("HUSKY SIBERIANO: 60 MINUTOS. COSTO: RD$300");
        }
    }
}
