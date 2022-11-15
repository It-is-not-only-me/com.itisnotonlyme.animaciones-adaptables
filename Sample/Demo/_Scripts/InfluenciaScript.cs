using ItIsNotOnlyMe.AnimacionesAdaptables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenciaScript : MonoBehaviour, IInfluencia<Transformacion>
{
    [SerializeField] private Transformacion _transformacion;
    [SerializeField] private float _influencia;

    public Transformacion EstadoActual() => Transformacion.Escalar(_transformacion, _influencia);
}
