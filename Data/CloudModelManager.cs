using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment2.Models.Unit;
using DNP_Assignment2.Data;

namespace Assignment2.Data
{
    public class CloudModelManager
    {
        public string AddUser(User newUser)
        {
            throw new System.NotImplementedException();
        }

        public static async Task<bool> LoginAsync(User user)
        {
            Console.WriteLine(1);
            string userJson = JsonSerializer.Serialize(user);
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:5003/api/user"+userJson);
            bool result = Convert.ToBoolean(message);
            return result;
        }

        public UserList GetAllUser()
        {
            throw new System.NotImplementedException();
        }

        public string UpdatePassword(User oldUser, User newUser)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new System.NotImplementedException();
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