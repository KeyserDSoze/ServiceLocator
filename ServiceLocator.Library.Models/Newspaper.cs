using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator.Library.Models
{
    public sealed class Newspaper
    {
        public IList<News> News { get; } = new List<News>()
        {
            new News()
            {
                Id = 1,
                Title = "Dendo",
                Description = "Descirpiotndbsa 1"
            },
            new News()
            {
                Id = 2,
                Title = "Kdls",
                Description = "Dnska oieowiqeq 2"
            },
        };
    }
}
