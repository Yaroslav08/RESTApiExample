using RESTApiLibrary;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RESTClient client = new RESTClient();
            var users = await client.GetAllUsersAsync();
            Console.WriteLine(users.First().ToString());
        }
    }
}
