using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP_Assignment2_Client.Models.List;
using DNP_Assignment2_Client.Models.Unit;

namespace DNP_Assignment2_Client.Data
{
    public class CloudModelManager : IModelManager
    {
        private HttpClient client;
        private readonly string uri = "https://localhost:5003/api/";

        public CloudModelManager()
        {
            try
            {
                client = new HttpClient();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var httpClientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (requestMessage, certificate2, arg3, arg4) => true
                };
                client = new HttpClient(httpClientHandler);
            }
            
        }
        public async Task<string> AddUserAsync(User newUser)
        {
            var newUserJson = JsonSerializer.Serialize(newUser);
            HttpContent httpContent = new StringContent(newUserJson,Encoding.UTF8,"application/json");
            var message = await client.PostAsync(uri + "user",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<bool> LoginAsync(User user)
        {
            var userJson = JsonSerializer.Serialize(user);
            var message = await client.GetStringAsync(uri + "user/login?userJson=" + userJson);
            bool result = Convert.ToBoolean(message);
            return result;
        }

        public async Task<UserList> GetAllUserAsync()
        {
            var message = await client.GetStringAsync(uri + "user");
            var result = JsonSerializer.Deserialize<UserList>(message);
            return result;
        }

        public async Task<string> UpdatePasswordAsync(User oldUser, User newUser)
        {
            List<User> userList = new List<User> {oldUser, newUser};
            var userListJson = JsonSerializer.Serialize(userList);
            HttpContent httpContent = new StringContent(userListJson,Encoding.UTF8,"application/json");
            var message = await client.PatchAsync(uri + "user",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task RemoveUserAsync(User user)
        {
            await client.DeleteAsync(uri + "user?userName=" + user.UserName);
        }

        public async Task<string> AddFamilyAsync(Family newFamily)
        {
            var newFamilyJson = JsonSerializer.Serialize(newFamily);
            HttpContent httpContent = new StringContent(newFamilyJson,Encoding.UTF8,"application/json");
            var message = await client.PostAsync(uri + "family",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<FamilyList> GetAllFamilyAsync()
        {
            var message = await client.GetStringAsync(uri + "family");
            var result = JsonSerializer.Deserialize<FamilyList>(message);
            return result;
        }

        public async Task<string> UpdateFamilyAsync(Family oldFamily, Family newFamily)
        {
            var familyList = new List<Family> {oldFamily,newFamily};
            var familyListJson = JsonSerializer.Serialize(familyList);
            HttpContent httpContent = new StringContent(familyListJson,Encoding.UTF8,"application/json");
            var message = await client.PatchAsync(uri + "family",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task RemoveFamilyAsync(Family family)
        {
            await client.DeleteAsync(uri + "family?streetName=" + family.StreetName + "&houseNumber=" + family.HouseNumber);
        }

        public async Task<string> AddAdultAsync(Adult newAdult)
        {
            var newAdultJson = JsonSerializer.Serialize(newAdult);
            HttpContent httpContent = new StringContent(newAdultJson,Encoding.UTF8,"application/json");
            var message = await client.PostAsync(uri + "person/adult",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<AdultList> GetAllAdultAsync()
        {
            var message = await client.GetStringAsync(uri + "person/adult");
            var result = JsonSerializer.Deserialize<AdultList>(message);
            return result;
        }

        public async Task<string> AddChildAsync(Child newChild)
        {
            var newChildJson = JsonSerializer.Serialize(newChild);
            HttpContent httpContent = new StringContent(newChildJson,Encoding.UTF8,"application/json");
            var message = await client.PostAsync(uri + "person/child",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<ChildList> GetAllChildAsync()
        {
            var message = await client.GetStringAsync(uri + "person/child");
            var result = JsonSerializer.Deserialize<ChildList>(message);
            return result;
        }

        public async Task<string> UpdatePersonAsync(Person newPerson)
        {
            string newPersonJson;
            try
            {
                newPersonJson = JsonSerializer.Serialize((Adult) newPerson);
            }
            catch 
            {
                newPersonJson = JsonSerializer.Serialize((Child) newPerson);
            }
            newPersonJson = JsonSerializer.Serialize(newPersonJson);
            HttpContent httpContent = new StringContent(newPersonJson,Encoding.UTF8,"application/json");
            var message = await client.PatchAsync(uri + "person",httpContent);
            var result = await message.Content.ReadAsStringAsync();
            return result;
        }

        public async Task RemovePersonAsync(Person person)
        {
            await client.DeleteAsync(uri + "person?id=" + person.Id);
        }
    }
}