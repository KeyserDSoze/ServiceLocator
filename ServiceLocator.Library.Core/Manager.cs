using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ServiceLocator.Library.Models;
using System;

namespace ServiceLocator.Library.Core
{
    public class Manager
    {
        //Like a FlyWeight (Scoped), it's not lazy
        public Newspaper Newspaper { get; } = new Newspaper();

        //Like a FlyWeight (Scoped), it's lazy
        private IUser user;
        public IUser User => user ?? (user = new User(this.HttpContextAccessor));

        //Like a Singleton (Singleton)
        private static ServiceContext serviceContext = new ServiceContext();
        public ServiceContext ServiceContext => serviceContext;

        //Like a factory (Transient)
        public Transaction Transaction => new Transaction();


        private readonly IHttpContextAccessor HttpContextAccessor;
        public Manager(IHttpContextAccessor httpContextAccessor) => this.HttpContextAccessor = httpContextAccessor;
    }
    public static class ManagerExtensions
    {
        public static void AddManager(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<Manager>();
        }
    }
}
