using UnityEngine;

[System.Serializable]
public struct Transformacion
{
    [SerializeField] public Vector3 Posicion;
    [SerializeField] public Quaternion Rotacion;

    public Transformacion(Vector3 posicion, Quaternion rotacion)
    {
        Posicion = posicion;
        Rotacion = rotacion;
    }

    public static Transformacion Nula() => new Transformacion(Vector3.zero, Quaternion.identity);

    public static Transformacion Sumar(Transformacion primero, Transformacion segundo)
    {
        return new Transformacion(
            primero.Posicion + segundo.Posicion,
            Quaternion.Slerp(primero.Rotacion, segundo.Rotacion, 0.5f)
        );
    }

    public static Transformacion Escalar(Transformacion transformacion, float escalar)
    {
        return new Transformacion(
            transformacion.Posicion * escalar,
            Quaternion.Slerp(transformacion.Rotacion, Quaternion.identity, escalar)
        );
    }
}