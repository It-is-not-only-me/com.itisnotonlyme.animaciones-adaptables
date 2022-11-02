using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class InfluenciaPrueba : IInfluencia
{
    private Transformacion _posicionInicial, _posicionFinal;
    private float _tiempoObjetivo, _dt;
    private float _tiempoActual;

    public InfluenciaPrueba( Transformacion posicionInicial, Transformacion posicionFinal, float tiempoObjetivo, float dt )
    {
        _posicionInicial = posicionInicial;
        _posicionFinal = posicionFinal;
        _tiempoObjetivo = tiempoObjetivo;
        _dt = dt;
        _tiempoActual = 0;
    }

    public Transformacion PosicionActual ( )
    {
        _tiempoActual = Mathf.Min( _tiempoActual + _dt, _tiempoObjetivo );
        float intervalo = _tiempoActual / _tiempoObjetivo;
        return Transformacion.Lerp( _posicionInicial, _posicionFinal, intervalo );
    }
}

public class MovimientoPrueba : IMovimiento
{
    private float _velocidad;

    public MovimientoPrueba( float velocidad )
    {
        _velocidad = velocidad;
    }

    public Transformacion Mover ( Transformacion posicionActual, Transformacion posicionObjetivo, float dt )
    {
        float intervalo = CantidadDeInfluencia( posicionActual, posicionObjetivo, dt );
        return Transformacion.Lerp(posicionActual, posicionObjetivo, intervalo);
    }

    private float CantidadDeInfluencia ( Transformacion posicionActual, Transformacion posicionObjetivo, float dt )
    {
        float distancia = Transformacion.Distancia( posicionActual, posicionObjetivo );
        return Mathf.Min( 1f, distancia / ( _velocidad * dt ) );
    }
}

public class CombinacionPrueba : ICombinacion
{
    private List<float> _pesos;

    public CombinacionPrueba(List<float> pesos)
    {
        _pesos = pesos;
    }

    public Transformacion Combinar(List<Transformacion> posiciones)
    {

        for ( int i = 0; i < posiciones.Count; i++)
        {
            
        }

        return new Transformacion();
    }
}

public class NodoTest
{
    [Test]
    public void Test01()
    {

    }
}
