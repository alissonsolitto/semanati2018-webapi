using System.Collections.Generic;
using semanati2018_webapi.Interfaces;
using webapi.Data;
using webapi.Model;

namespace semanati2018_webapi.Services
{
    public class UserService : IUserService
    {
        public void Create(UserModel user)
        {
            ListData.lstUser.Add(user);
        }

        public bool Delete(int id)
        {
            var user = ListData.lstUser.Find(x => x.Id == id);

            if(user != null)
            {
                ListData.lstUser.Remove(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserModel FindEmail(string email)
        {
            return ListData.lstUser.Find(x => x.Email == email);
        }

        public UserModel FindName(string name)
        {
            return ListData.lstUser.Find(x => x.Name == name);
        }

        public List<UserModel> GetAll()
        {
            return ListData.lstUser;
        }

        public bool Update(int id, UserModel user)
        {
            int index = ListData.lstUser.FindIndex(x => x.Id == id);

            if(index >= 0)
            {

                ListData.lstUser[index] = user;
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}