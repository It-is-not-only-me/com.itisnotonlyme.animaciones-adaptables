using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface IInfluencia<TTipo>
    {
        public TTipo EstadoActual();
    }
}
