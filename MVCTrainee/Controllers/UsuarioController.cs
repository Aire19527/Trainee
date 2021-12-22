using Infraestrcture.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using MVC.Domain.Services;
using MVC.Domain.Services.Interfaces;

namespace MVCTrainee.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserServices _userServices;

        public UsuarioController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _userServices.GetAllUser();
            return View(users);
        }

        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            var users = _userServices.Login(username, password);

            //localhost:5412/Usuario/Login?usernmer=pepito&?password=123
            return Ok(users);
        }


        [HttpPost]
        public IActionResult Login(UsuarioEntity  user)
        {
            var users = _userServices.Login(user);


            return Ok(users);
        }

    }
}
