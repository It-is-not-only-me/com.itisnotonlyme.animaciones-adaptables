using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface ICombinacion
    {
        public Transformacion Combinar( List<Transformacion> posiciones );
    }
}