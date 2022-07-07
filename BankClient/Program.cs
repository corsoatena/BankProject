using ApiProxy;
using ApiProxy.DTo;
using Newtonsoft.Json;
using System;

namespace BankClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtmApp atm = new AtmApp();
            string  result = atm.GetSaldo();
            RootElement data = JsonConvert.DeserializeObject<RootElement>(result);

            foreach (var user in data.Users)
            {
                Console.WriteLine($" Nome:{ user.name }");
                Console.WriteLine($" Age:{ user.age }");

                foreach (var prelievo in user.prelievi)
                {
                    Console.WriteLine($"       Valuta: {prelievo.currency}");
                    Console.WriteLine($"       Totale: {prelievo.amount}");
                    Console.WriteLine();

                }
            }
            //// STRUTTURE DATI ATTRAVERSO IL WEB SOLO XML JSON

            /// .NET C# 
            /// Serialization  ->> object -> json or xml(SOAP) WEB SERVICES
            /// REST API -> https ------> json 
            /// ------------ INTERNET --------------- > HTTP
            /// Deserialization -> convert json, xml  ->>> object C#, JAVA, PYTHON 

        }
    }
}
