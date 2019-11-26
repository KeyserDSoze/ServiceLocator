using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator.Library.Models
{
    public class Transaction
    {
        public string Id { get; } = Guid.NewGuid().ToString("N");
    }
}
