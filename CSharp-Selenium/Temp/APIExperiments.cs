using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpSelenium.Temp
{
    //DTO data transfer object
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class APIExperiments
    {
        private readonly RestClient _client;
        public APIExperiments(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }
        public RestResponse CreateUser(string username, string password)
        {
            var request = new RestRequest("/users", Method.Post);
            request.AddJsonBody(request);
            return _client.Execute(request);
        }
        public RestResponse GetUser(int  userId)
        {
            var request = new RestRequest($"users/{userId}", Method.Get);
            return _client.Execute(request);
        }
        public UserResponse GetUserModel(int userId)
        {
            var user = JsonSerializer.Deserialize<UserResponse>(GetUser(userId).Content);
            return user;
        }
        public UserResponse GetUserModel2(int userId)
        {
            var request = new RestRequest($"users/{userId}", Method.Get);
            var response = _client.Execute<UserResponse>(request);
            var user = response.Data;
            return user;
        }
    }
}
