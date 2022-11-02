using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public class Nodo : INodo
    {
        private Transformacion _posicionActual;
        private IMovimiento _movimiento;
        private ICombinacion _combinacion;
        private List<IInfluencia> _influencias;

        public Nodo(Transformacion posicionInicial, IMovimiento movimiento, ICombinacion combinacion, List<IInfluencia> influencias = null)
        {
            _posicionActual = posicionInicial;
            _movimiento = movimiento;
            _combinacion = combinacion;
            _influencias = (influencias == null) ? new List<IInfluencia>() : influencias;
        }

        public void AgregarInfluencia(IInfluencia influencia)
        {
            _influencias.Add(influencia);
        }

        public Transformacion PosicionFinal(float dt)
        {
            List<Transformacion> posicionesInfluenciadas = new List<Transformacion>();
            _influencias.ForEach( influencia => posicionesInfluenciadas.Add( influencia.PosicionActual() ) );

            Transformacion posicionObjetivo = _combinacion.Combinar( posicionesInfluenciadas );

            _posicionActual = _movimiento.Mover( _posicionActual, posicionObjetivo, dt );
            return _posicionActual;
        }
    }

}