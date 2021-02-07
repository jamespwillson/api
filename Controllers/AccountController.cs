using api.Models;
using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet]
        public IEnumerable<Account> GetAll()
        {
            var accounts = _accountService.GetAll();
            return accounts;
        }
    }
}