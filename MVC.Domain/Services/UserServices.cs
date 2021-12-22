using Infraestrcture.Entity.Entity;
using MVC.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace MVC.Domain.Services
{
    public class UserServices : IUserServices
    {
        public bool Login(string username, string password)
        {
            bool result = false;

            if (username == "jprodriguez" && password == "123")
                result = true;

            return result;
        }

        public bool Login(UsuarioEntity user)
        {
            bool result = false;

            if (user.UserName == "jprodriguez" && user.Password == "123")
                result = true;

            return result;
        }
        public List<UsuarioEntity> GetAllUser()
        {
            List<UsuarioEntity> users = new List<UsuarioEntity>();

            for (int i = 0; i < 15; i++)
            {
                users.Add(new UsuarioEntity()
                {
                    UserName = $"User {i}",
                    Password = $"Pass {i}",
                    Name = $"Name {i}",
                    LastName = $"Last {i}"
                });
            }

            return users;
        }
    }
}
