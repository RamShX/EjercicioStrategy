using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Modelos
{
    public class Chiguagua : IPaseadorServicio
    {
        public void PasearMascota()
        {
            Console.WriteLine("20 MINUTOS. COSTO: RD$100");
        }
    }
}
