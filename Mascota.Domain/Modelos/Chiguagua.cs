using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Modelos
{
    public class Chiguagua : IEstrategiaPaseo
    {
        public void PasearMascota()
        {
            Console.WriteLine("CHIHUAHUA: 20 MINUTOS. COSTO: RD$100");
        }
    }
}
