using Infraestrcture.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Domain.Services.Interfaces
{
    public interface IUserServices
    {
        bool Login(string username, string password);
        bool Login(UsuarioEntity user);
        List<UsuarioEntity> GetAllUser();
    }
}
