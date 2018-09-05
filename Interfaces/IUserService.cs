using System.Collections.Generic;
using webapi.Model;

namespace semanati2018_webapi.Interfaces
{
    public interface IUserService
    {
        void Create(UserModel user);
        bool Update(int id, UserModel user);
        bool Delete(int id);
        List<UserModel> GetAll();
        UserModel FindName(string name);
        UserModel FindEmail(string email);
    }
}