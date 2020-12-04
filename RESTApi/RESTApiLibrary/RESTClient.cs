using RESTApiLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
namespace RESTApiLibrary
{
    public class RESTClient
    {
        private HttpClient httpClient;
        public RESTClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://www.localhost:5001");
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await httpClient.GetFromJsonAsync<List<User>>("api/users");
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<User>($"api/users/{id}");
        }

        public async Task<User> CreateUserAsync(User user)
        {
            return await httpClient.PostAsJsonAsync<User>("api/users", user);
        }
    }
}