using System;
using System.Collections.Generic;
using api.Models;

namespace api.Services.Interfaces
{
    public interface IAccountInterface
    {
        IEnumerable<Account> GetAll();
    }
}
