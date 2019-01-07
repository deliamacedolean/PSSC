using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    public abstract class ProcesatorComandaGeneric<T> : ProcesatorComanda where T : Comanda
    {
        public abstract Carte Proceseaza(T comanda);

        public override Carte Proceseaza(Comanda comanda)
        {
            return Proceseaza((T)comanda); // TODO DELIA return
           
        }
    }
}