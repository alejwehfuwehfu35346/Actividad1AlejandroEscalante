using System;

namespace BusinessServicesLayer
{
    public class ComputadoraBss
    {
        private readonly ComputadoraDal computadoraDal;

        public ComputadoraBss(ComputadoraDal computadoraDal)
        {
            this.computadoraDal = computadoraDal;
        }

        public void Insertar(Computadora computadora)
        {
            // Validaciones de negocio, si es necesario
            computadoraDal.Insertar(computadora);
        }

        public Computadora ObtenerPorId(int id)
        {
            return computadoraDal.ObtenerPorId(id);
        }

        public void Actualizar(Computadora computadora)
        {
            // Validaciones de negocio, si es necesario
            computadoraDal.Actualizar(computadora);
        }

        public void Eliminar(int id)
        {
            computadoraDal.Eliminar(id);
        }
    }
}