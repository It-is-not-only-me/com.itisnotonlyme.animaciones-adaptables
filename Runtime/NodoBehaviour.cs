using ItIsNotOnlyMe.AnimacionesAdaptables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NodoBehaviour<TTipo> : MonoBehaviour, INodo<TTipo>
{
    protected Nodo<TTipo> _nodo;

    public void AgregarInfluencia(IInfluencia<TTipo> influencia)
    {
        _nodo.AgregarInfluencia(influencia);
    }

    public TTipo EstadoActual()
    {
        return _nodo.EstadoActual();
    }

    public abstract void ModificarEstado();
}
