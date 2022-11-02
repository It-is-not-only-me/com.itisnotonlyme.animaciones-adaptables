using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface INodo
    {
        public void AgregarInfluencia(IInfluencia influencia);

        public Transformacion PosicionFinal(float dt);
    }
}