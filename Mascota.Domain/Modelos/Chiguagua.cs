using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Modelos
{
    public class Chiguagua : IEstrategiaPaseo
    {
        public void PasearMascota()
        {
            Console.WriteLine("20 MINUTOS. COSTO: RD$100");
        }
    }
}
