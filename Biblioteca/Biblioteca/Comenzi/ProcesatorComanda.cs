using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    public abstract class ProcesatorComanda
    {
        public abstract Carte Proceseaza(Comanda comanda);
    }
}