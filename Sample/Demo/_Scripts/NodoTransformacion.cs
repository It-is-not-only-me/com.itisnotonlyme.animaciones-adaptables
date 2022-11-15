using System;
using System.Collections;
using System.Collections.Generic;
using ItIsNotOnlyMe.AnimacionesAdaptables;

public class NodoTransformacion : Nodo<Transformacion>
{
    public NodoTransformacion(Transformacion estadoInicial)
        : base(estadoInicial)
    {
    }

    public override Transformacion EstadoActual()
    {
        if (!HayInfluencia())
            return _estadoInicial;

        IInfluencia<Transformacion>.Estado estado = _influencias[0].EstadoActual();
        Transformacion estadoFinal = Transformacion.Escalar(estado.EstadoActual, estado.Influencia);

        for (int i = 1; i < _influencias.Count; i++)
        {
            estado = _influencias[i].EstadoActual();
            estadoFinal = Transformacion.Sumar(estadoFinal, Transformacion.Escalar(estado.EstadoActual, estado.Influencia));
        }

        return Transformacion.Sumar(estadoFinal, _estadoInicial);
    }

    private bool HayInfluencia() => _influencias.Count > 0;
}


