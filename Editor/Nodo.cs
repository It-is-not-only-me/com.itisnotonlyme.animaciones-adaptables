
using System.Collections.Generic;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public abstract class Nodo<TTipo> : INodo<TTipo>
    {
        protected TTipo _estadoInicial;
        protected List<IInfluencia<TTipo>> _influencias;

        public Nodo(TTipo estadoInicial)
        {
            _influencias = new List<IInfluencia<TTipo>>();
            _estadoInicial = estadoInicial;
        }

        public void AgregarInfluencia(IInfluencia<TTipo> influencia)
        {
            _influencias.Add(influencia);
        }

        public abstract TTipo EstadoActual();
    }
}