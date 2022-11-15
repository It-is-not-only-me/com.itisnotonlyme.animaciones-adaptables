using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.AnimacionesAdaptables;
using System;

public class InfluenciaAnimacion : MonoBehaviour, IInfluencia<Transformacion>
{
    [SerializeField] private Transformacion _transformacion;
    [SerializeField][Range(0,1)] private float _influencia;

    private IInfluencia<Transformacion>.Estado _estado;

    IInfluencia<Transformacion>.Estado IInfluencia<Transformacion>.EstadoActual()
    {
        ActualizarEstado();
        return _estado;
    }

    private void ActualizarEstado()
    {
        _estado.EstadoActual = _transformacion;
        _estado.Influencia = _influencia;
    }
}
