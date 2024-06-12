using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjAndreVeiculosSummary.BankAPI.Services;

namespace ProjAndreVeiculosSummary.BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {

        private readonly BankService _bankService;

        public BankController(BankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public ActionResult<List<Bank>> GetBanks()
        {
            return _bankService.GetBanks();
        }

        [HttpPost]
        public ActionResult<Bank> PostBank(Bank bank)
        {
            _bankService.Create(bank);
            return Ok(bank);
        }
    }
}
