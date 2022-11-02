using UnityEngine;

namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public struct Transformacion
    {
        public Vector3 Posicion { get; private set; }
        public Quaternion Rotacion { get; private set; }

        public Transformacion( Vector3 posicion = default(Vector3), Quaternion rotacion = default(Quaternion) )
        {
            Posicion = posicion;
            Rotacion = rotacion;
        }

        public static Transformacion Lerp ( Transformacion inicio, Transformacion final, float t)
        {
            Vector3 posicionFinal = Vector3.Lerp(inicio.Posicion, final.Posicion, t);
            Quaternion rotacionFinal = Quaternion.Slerp(inicio.Rotacion, final.Rotacion, t);
            return new Transformacion(posicionFinal, rotacionFinal);
        }

        public static Transformacion operator + ( Transformacion primero, Transformacion segundo )
        {
            return new Transformacion( primero.Posicion + segundo.Posicion, primero.Rotacion * segundo.Rotacion );
        }

        public static Transformacion operator - ( Transformacion otro )
        {
            return new Transformacion( -otro.Posicion, Quaternion.Inverse( otro.Rotacion ) );
        }

        public static Transformacion operator - ( Transformacion primero, Transformacion segundo )
        {
            return primero + (-segundo);
        }

        public static float Distancia ( Transformacion primero, Transformacion segundo )
        {
            return Vector3.Distance( primero.Posicion, segundo.Posicion );
        }
    }
}