namespace Biblioteca.Comenzi
{
    public abstract class ProcesatorComandaGeneric<T> : ProcesatorComanda where T : Comanda
    {
        public abstract void Proceseaza(T comanda);

        public override void Proceseaza(Comanda comanda)
        {
            Proceseaza((T)comanda);
        }
    }
}