using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class InfluenciaAnimacion : MonoBehaviour, IInfluencia<Transformacion>
{
    [SerializeField] private Transformacion _transformacion;
    [SerializeField] private float _influencia;

    public Transformacion EstadoActual() => Transformacion.Escalar(_transformacion, _influencia);
}
