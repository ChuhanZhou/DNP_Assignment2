using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Assignment2.Models.Unit;
using DNP_Assignment2.Data;

namespace Assignment2.Data
{
    public class CloudModelManager
    {
        private HttpClient client;
        private readonly string uri = "https://localhost:5003/api/user";

        public CloudModelManager()
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (requestMessage, certificate2, arg3, arg4) => true
            };
            client = new HttpClient(httpClientHandler);
        }
        public async Task<string> AddUserAsync(User newUser)
        {
            string newUserJson = JsonSerializer.Serialize(newUser);
            HttpContent httpContent = new StringContent(newUserJson,Encoding.UTF8,"application/json");
            var message = await client.PostAsync(uri,httpContent);
            string result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<bool> LoginAsync(User user)
        {
            string userJson = JsonSerializer.Serialize(user);
            string message = await client.GetStringAsync(uri + "/login?userJson=" + userJson);
            bool result = Convert.ToBoolean(message);
            return result;
        }

        public async Task<UserList> GetAllUserAsync()
        {
            string message = await client.GetStringAsync(uri);
            var result = JsonSerializer.Deserialize<UserList>(message);
            return result;
        }

        public async Task<string> UpdatePasswordAsync(User oldUser, User newUser)
        {
            List<User> userList = new List<User>();
            userList.Add(oldUser);
            userList.Add(newUser);
            string userListJson = JsonSerializer.Serialize(userList);
            HttpContent httpContent = new StringContent(userListJson,Encoding.UTF8,"application/json");
            var message = await client.PatchAsync(uri,httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task RemoveUserAsync(User user)
        {
            await client.DeleteAsync(uri + "?userName=" + user.UserName);
        }

        public string AddFamily(Family newFamily)
        {
            throw new System.NotImplementedException();
        }

        public FamilyList GetAllFamily()
        {
            throw new System.NotImplementedException();
        }

        public string UpdateFamily(Family oldFamily, Family newFamily)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public string AddAdult(Adult newAdult)
        {
            throw new System.NotImplementedException();
        }

        public AdultList GetAllAdult()
        {
            throw new System.NotImplementedException();
        }

        public string AddChild(Child newChild)
        {
            throw new System.NotImplementedException();
        }

        public ChildList GetAllChild()
        {
            throw new System.NotImplementedException();
        }

        public string UpdatePerson(Person newPerson)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePerson(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}