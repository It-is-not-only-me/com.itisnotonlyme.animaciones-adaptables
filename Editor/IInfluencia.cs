using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface IInfluencia<TTipo>
    {
        public struct Estado
        {
            public TTipo EstadoActual;
            public float Influencia;

            public Estado(TTipo estadoActual, float influencia)
            {
                EstadoActual = estadoActual;
                Influencia = influencia;
            }
        }

        public Estado EstadoActual();
    }
}
