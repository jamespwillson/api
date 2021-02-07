using api.Models;
using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactService _contactService;

        public ContactController(ILogger<ContactController> logger, IContactService contactService)
        {
            _logger = logger;
            _contactService = contactService;
        }

        [HttpGet]
        public IEnumerable<Contact> GetAll()
        {
            var contacts = _contactService.GetAll();
            return contacts;
        }
    }
}
