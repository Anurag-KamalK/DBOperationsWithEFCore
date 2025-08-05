using DBOperationsWithEFCoreApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBOperationsWithEFCoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult CurreniesGet()
        {
            var result= this._appDbContext.Currencies.ToList();
            return Ok(result);
        }
    }
}
