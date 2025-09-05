using DBOperationsWithEFCoreApi.Data;
using DBOperationsWithEFCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            this._currencyService = currencyService;
        }

        [HttpGet]
        public async Task<JsonResult> CurreniesGet()
        {
            return await this._currencyService.CurreniesGetService();
        }

        [HttpGet("{Id}")]
        public async Task<JsonResult> CurreniesGetById([FromRoute] long Id)
        {
            return await this._currencyService.CurreniesGetByIdService(Id);
        }

    }
}

