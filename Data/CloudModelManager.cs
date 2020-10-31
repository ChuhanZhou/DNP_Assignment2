﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment2.Models.Unit;
using DNP_Assignment2.Data;

namespace Assignment2.Data
{
    public class CloudModelManager
    {
        private HttpClient client;
        private readonly string uri = "https://localhost:5003/api/";

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