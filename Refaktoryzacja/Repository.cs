using System.Collections.Generic;

namespace Refaktoryzacja
{
    static class Repository
    {
        public static List<Client> Clients;
        static Repository()
        {
            Clients = new List<Client>();
            Clients.Add(new Client(1, "vip", 1000));
            Clients.Add(new Client(2, "vip", 2000));
            Clients.Add(new Client(3, "gold", 500));
            Clients.Add(new Client(4, "gold", 200));
            Clients.Add(new Client(5, "", 10));
            Clients.Add(new Client(6, "", 20));
        }
    }
}
