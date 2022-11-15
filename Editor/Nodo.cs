
using System.Collections.Generic;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public abstract class Nodo<TTipo> : INodo<TTipo>
    {
        protected List<IInfluencia<TTipo>> _influencias;

        public Nodo()
        {
            _influencias = new List<IInfluencia<TTipo>>();
        }

        public void AgregarInfluencia(IInfluencia<TTipo> influencia)
        {
            _influencias.Add(influencia);
        }

        public abstract TTipo EstadoActual();
    }
}