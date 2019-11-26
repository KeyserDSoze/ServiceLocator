using ServiceLocator.Library.Core;
using System;
using System.Linq;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(null);
            var t = manager.Newspaper.News.First().Description;
        }
    }
}
