using ClassesAbstratasESeladas.Abstract;
using ClassesAbstratasESeladas.Sealed;
using System;

namespace ClassesAbstratasESeladas
{
    class Program
    {
        static void Main(string[] args)
        {
            var classeAbstrata = new ClientEntity();
            classeAbstrata.Id = 10;

            var cliente = new ClientEntity();
            cliente.IsValid(); // Estou puxando o método do cliente, pois lá ele está sendo sobreescrito da classe base que é a "EntityBase".


            //Classes seladas
            var request = new ProdutoRequest();
            var requestBase = new RequestBase();
            requestBase.GetType();// Só tem acesso aos métodos nativos.


        }
    }
}
