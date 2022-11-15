namespace ItIsNotOnlyMe.AnimacionesAdaptables
{
    public interface INodo<TTipo>
    {
        public void AgregarInfluencia(IInfluencia<TTipo> influencia);

        public TTipo EstadoActual();
    }
}