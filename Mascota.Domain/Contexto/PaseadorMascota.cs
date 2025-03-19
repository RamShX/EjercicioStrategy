using Mascota.Domain.Interfaces;

namespace Mascota.Domain.Contexto
{
    public class PaseadorMascota
    {
        private IEstrategiaPaseo _estrategiaPaseo;

        public PaseadorMascota(IEstrategiaPaseo estrategiaPaseo)
        {
            _estrategiaPaseo = estrategiaPaseo;
        }

        public void PasearMascota()
        {
            _estrategiaPaseo.PasearMascota();
        }
    }
}
