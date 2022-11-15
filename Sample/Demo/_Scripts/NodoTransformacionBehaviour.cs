using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class NodoTransformacionBehaviour : NodoBehaviour<Transformacion>
{
    private void Awake()
    {
        _nodo = new NodoTransformacion(new Transformacion(transform.localPosition));
        foreach (IInfluencia<Transformacion> influencia in GetComponents<IInfluencia<Transformacion>>())
            _nodo.AgregarInfluencia(influencia);
    }

    private void Update() => ModificarEstado();

    public override void ModificarEstado()
    {
        Transformacion transformacionActual = EstadoActual();
        transform.localPosition = transformacionActual.Posicion;
    }
}
