using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Transformacion
{
    [SerializeField] public Vector3 Posicion;

    public Transformacion(Vector3 posicion)
    {
        Posicion = posicion;
    }

    public static Transformacion Sumar(Transformacion primero, Transformacion segundo)
    {
        return new Transformacion(primero.Posicion + segundo.Posicion);
    }

    public static Transformacion Escalar(Transformacion transformacion, float escalar)
    {
        return new Transformacion(transformacion.Posicion * escalar);
    }
}