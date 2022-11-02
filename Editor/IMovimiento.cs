using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface IMovimiento
    {
        public Transformacion Mover( Transformacion posicionActual, Transformacion posicionObjetivo, float dt );
    }
}