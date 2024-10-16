using SignupPagewithbasecontroller.Models;
using System.Collections.Generic;
namespace SignupPagewithbasecontroller.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAllUsers();  
        UserModel GetUserById(int id);         
        void AddUser(UserModel user);          
        void UpdateUser(UserModel user);       
        void DeleteUser(int id);              
    }
}

