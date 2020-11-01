using System.Threading.Tasks;
using Assignment2.Models.Unit;
using DNP_Assignment2.Data;

namespace Assignment2.Data
{
    public interface IModelManager
    {
        Task<string> AddUserAsync(User newUser);
        Task<bool> LoginAsync(User user);
        Task<UserList> GetAllUserAsync();
        Task<string> UpdatePasswordAsync(User oldUser,User newUser);
        Task RemoveUserAsync(User user);
        Task<string> AddFamilyAsync(Family newFamily);
        Task<FamilyList> GetAllFamilyAsync();
        Task<string> UpdateFamilyAsync(Family oldFamily, Family newFamily);
        Task RemoveFamilyAsync(Family family);
        Task<string> AddAdultAsync(Adult newAdult);
        Task<AdultList> GetAllAdultAsync();
        Task<string> AddChildAsync(Child newChild);
        Task<ChildList> GetAllChildAsync();
        Task<string> UpdatePersonAsync(Person newPerson);
        Task RemovePersonAsync(Person person);
    }
}