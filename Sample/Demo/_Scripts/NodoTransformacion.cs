using System.Collections;
using System.Collections.Generic;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class NodoTransformacion : Nodo<Transformacion>
{
    public override Transformacion EstadoActual()
    {
        if (HayInfluencia())
            return Transformacion.Nula();

        Transformacion estadoActual = _influencias[0].EstadoActual();

        for (int i = 1; i < _influencias.Count; i++)
            estadoActual = Transformacion.Sumar(estadoActual, _influencias[i].EstadoActual());

        return estadoActual;
    }

    private bool HayInfluencia() => _influencias.Count > 0;
}


