using System.Collections.Generic;
using webapi.Model;

namespace webapi.Data
{
    public static class ListData
    {
        public static List<UserModel> lstUser = new List<UserModel>(){
            new UserModel(1, "Alisson", "alisson@gmail.com", "123"),
            new UserModel(2, "Teste", "teste@gmail.com", "123"),
            new UserModel(3, "User03", "user03@gmail.com", "123"),
            new UserModel(4, "User04", "user04@gmail.com", "321"),
            new UserModel(5, "User05", "user05@gmail.com", "123"),
        };
    }
}