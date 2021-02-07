using System;
using System.Collections.Generic;
using api.Models;

namespace api.Services.Interfaces
{
    public interface IContactInterface
    {
        IEnumerable<Contact> GetAll();
    }
}