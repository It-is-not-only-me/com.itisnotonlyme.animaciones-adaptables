using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class NodoTransformacionBehaviour : MonoBehaviour, INodo<Transformacion>
{
    private NodoTransformacion _nodo;

    private void Awake()
    {
        _nodo = new NodoTransformacion();

        foreach (IInfluencia<Transformacion> influencia in GetComponents<IInfluencia<Transformacion>>())
            _nodo.AgregarInfluencia(influencia);
    }

    private void Update()
    {
        Transformacion transformacionActual = EstadoActual();
        Vector3 posicion = transformacionActual.Posicion;
        Quaternion rotacion = transformacionActual.Rotacion;

        Debug.Log(posicion);

        transform.SetPositionAndRotation(posicion, rotacion);
    }

    public void AgregarInfluencia(IInfluencia<Transformacion> influencia) => _nodo.AgregarInfluencia(influencia);

    public Transformacion EstadoActual() => _nodo.EstadoActual();
}
