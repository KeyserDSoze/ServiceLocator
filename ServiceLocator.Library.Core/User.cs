using Microsoft.AspNetCore.Http;
using ServiceLocator.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator.Library.Core
{
    public class User : IUser
    {
        private readonly IHttpContextAccessor HttpContextAccessor;
        public User(IHttpContextAccessor httpContextAccessor) => this.HttpContextAccessor = httpContextAccessor;
        public void Login()
        {
            var x = this.HttpContextAccessor.HttpContext.User.Identity;
            throw new NotImplementedException();
        }

        public void Logout()
        {
            var x = this.HttpContextAccessor.HttpContext.User.Identity;
            throw new NotImplementedException();
        }
    }
}
