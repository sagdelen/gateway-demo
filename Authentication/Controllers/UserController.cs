using Authentication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private static List<User> Users => new List<User>
        {
            new User
            {
                UserId = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                FirstName = "Allan",
                LastName = "Chua"
            },
            new User
            {
                UserId = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f"),
                FirstName = "Burr",
                LastName = "Sutter"
            },
            new User
            {
                UserId = Guid.Parse("3a4149fa-32e9-4d4a-a051-5c49b7ed2fca"),
                FirstName = "Josh",
                LastName = "Long"
            }
        };

        [HttpGet]
        public List<User> All()
        {
            return Users;
        }

        [HttpGet("/api/user/getbyid/{id}")]
        public User GetById(Guid? id)
        {
            return Users.FirstOrDefault(u => u.UserId == id);
        }
    }
}