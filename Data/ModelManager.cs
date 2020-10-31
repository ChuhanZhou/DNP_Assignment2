using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment2.Models.Unit;
using Assignment2.Persistence;
using DNP_Assignment2.Data;

namespace Assignment2.Data
{
    public class ModelManager : IModelManager
    {
        private ModelPackage modelPackage;
        private readonly string dataFileName;
        private CloudModelManager cloudModelManager;

        public ModelManager()
        {
            cloudModelManager = new CloudModelManager();
            modelPackage = new ModelPackage();
            dataFileName = "DataFile.json";
            ReadData();
        }

        private void ReadData()
        {
            DataFileContext.ReadData(dataFileName,modelPackage);
        }

        private void UpdateData()
        {
            DataFileContext.UpdateData(dataFileName,modelPackage);
        }

        public async Task<string> AddUserAsync(User newUser)
        {
            string result = await cloudModelManager.AddUserAsync(newUser);
            //string result = modelPackage.UserList.AddUser(newUser);
            return result;
        }

        public async Task<bool> LoginAsync(User user)
        {
            return await cloudModelManager.LoginAsync(user);
            //return modelPackage.UserList.CheckPassword(user);
        }

        public async Task<UserList> GetAllUserAsync()
        {
            return modelPackage.UserList.GetAllUser();
        }

        public async Task<string> UpdatePasswordAsync(User oldUser,User newUser)
        {
            //string result = modelPackage.UserList.UpdatePassword(oldUser,newUser);
            //UpdateData();
            return await cloudModelManager.UpdatePasswordAsync(oldUser,newUser);
        }

        public async Task RemoveUserAsync(User user)
        {
            //modelPackage.UserList.RemoveUser(user);
            //UpdateData();
            await cloudModelManager.RemoveUserAsync(user);
        }

        public async Task<string> AddFamilyAsync(Family newFamily)
        {
            return await cloudModelManager.AddFamilyAsync(newFamily);
        }

        public async Task<FamilyList> GetAllFamilyAsync()
        {
            return await cloudModelManager.GetAllFamilyAsync();
        }

        public async Task<string> UpdateFamilyAsync(Family oldFamily, Family newFamily)
        {
            return await cloudModelManager.UpdateFamilyAsync(oldFamily,newFamily);
        }

        public async Task RemoveFamilyAsync(Family family)
        {
            await cloudModelManager.RemoveFamilyAsync(family);
        }

        public string AddAdult(Adult newAdult)
        {
            if (modelPackage.ChildList.GetChildById(newAdult.Id)==null)
            {
                string result = modelPackage.AdultList.AddAdult(newAdult);
                UpdateData();
                return result;
            }
            return "This id is used.";
        }

        public AdultList GetAllAdult()
        {
            return modelPackage.AdultList.GetAllWithAdultList();
        }

        public string AddChild(Child newChild)
        {
            if (modelPackage.AdultList.GetAdultById(newChild.Id)==null)
            {
                string result = modelPackage.ChildList.AddChild(newChild);
                UpdateData();
                return result;
            }
            return "This id is used.";
        }

        public ChildList GetAllChild()
        {
            return modelPackage.ChildList.GetAllWithChildList();
        }

        public string UpdatePerson(Person newPerson)
        {
            string result = null;
            if (modelPackage.AdultList.GetAdultById(newPerson.Id)!=null)
            {
                result = modelPackage.AdultList.UpdateAdult((Adult) newPerson);
                if (result==null)
                {
                    foreach (var family in modelPackage.FamilyList.GetFamilyListByPerson(newPerson).families)
                    {
                        family.Adults.UpdateAdult((Adult) newPerson);
                    }
                }
            }
            else if (modelPackage.ChildList.GetChildById(newPerson.Id)!=null)
            {
                result = modelPackage.ChildList.UpdateChild((Child) newPerson);
                if (result==null)
                {
                    foreach (var family in modelPackage.FamilyList.GetFamilyListByPerson(newPerson).families)
                    {
                        family.Children.UpdateChild((Child) newPerson);
                    }
                }
            }
            UpdateData();
            return result;
        }

        public void RemovePerson(Person person)
        {
            modelPackage.AdultList.RemoveAdult(person);
            modelPackage.ChildList.RemoveChild(person);
            foreach (var family in modelPackage.FamilyList.families)
            {
                family.Adults.RemoveAdult(person);
                family.Children.RemoveChild(person);
            }
            UpdateData();
        }
    }
}