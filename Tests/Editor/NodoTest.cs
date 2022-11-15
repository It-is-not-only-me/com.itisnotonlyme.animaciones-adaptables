using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class NodoPrueba : Nodo<float>
{
    public NodoPrueba(float estadoInicial)
        : base(estadoInicial)
    {
    }

    public override float EstadoActual()
    {
        float _estadoFinal = _estadoInicial;
        foreach (IInfluencia<float> influencia in _influencias)
        {
            IInfluencia<float>.Estado estado = influencia.EstadoActual();
            _estadoFinal += estado.EstadoActual * estado.Influencia;
        }
        return _estadoFinal;
    }
}

public class InfluenciaPrueba : IInfluencia<float>
{
    private float _estadoActual;
    private float _influencia;

    public InfluenciaPrueba(float estadoActual, float influencia)
    {
        _estadoActual = estadoActual;
        _influencia = influencia;
    }

    IInfluencia<float>.Estado IInfluencia<float>.EstadoActual()
    {
        return new IInfluencia<float>.Estado(_estadoActual, _influencia);
    }
}

public class NodoTest
{
    [Test]
    public void Test01NodoSinInfluenciaSeMantieneEnSuEstadoInicial()
    {
        float estadoInicial = 2f;
        NodoPrueba nodo = new NodoPrueba(estadoInicial);

        Assert.AreEqual(estadoInicial, nodo.EstadoActual());
    }

    [Test]
    public void Test02NodoConInfluenciaVariaSuEstadoInicial()
    {
        float estadoInicial = 2f;
        NodoPrueba nodo = new NodoPrueba(estadoInicial);

        float estadoInfluencia = 4f;
        InfluenciaPrueba influencia = new InfluenciaPrueba(estadoInfluencia, 1f);

        nodo.AgregarInfluencia(influencia);

        Assert.AreEqual(estadoInicial + estadoInfluencia, nodo.EstadoActual());
    }

    [Test]
    public void Test03NodoConMuchasInfluenciasSuEstadoEsLaSumaDeEllas()
    {
        float estadoInicial = 2f;
        NodoPrueba nodo = new NodoPrueba(estadoInicial);

        float resultadoFinal = 2f;
        for (int i = 2; i < 20; i++)
        {
            float estadoInfluencia = 2f * i;
            nodo.AgregarInfluencia(new InfluenciaPrueba(estadoInfluencia, 1f));

            resultadoFinal += estadoInfluencia;
        }

        Assert.AreEqual(resultadoFinal, nodo.EstadoActual());
    }
}
