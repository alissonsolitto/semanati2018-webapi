using System.Collections.Generic;
using webapi.Model;

namespace webapi.Data
{
    public static class ListData
    {
        public static List<UserModel> lstUser = new List<UserModel>(){
            new UserModel(1, "Alisson", "alisson@gmail.com", "123"),
            new UserModel(2, "Teste", "teste@gmail.com", "abc123"),
        };
    }
}