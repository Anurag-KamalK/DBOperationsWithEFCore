using DBOperationsWithEFCoreApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<JsonResult> CurreniesGet()
        {
            //var result = await _appDbContext.Currencies.ToListAsync();
            var result = await (from currecies in _appDbContext.Currencies select currecies).ToListAsync();
            
            return new JsonResult(result);
        }

        [HttpGet("{Id}")]
        public async Task<JsonResult> CurreniesGetById([FromRoute] long Id)
        {
            var result = await _appDbContext.Currencies.FindAsync(Id);

            if (result == null)
            {
                return new JsonResult(new
                {
                    condition = "False",
                    message = "No Record Found.",
                    data = new object[] { }
                });
            }
            else
            {
                return new JsonResult(new
                {
                    condition = "True",
                    message = "Records Found.",
                    data = result
                });
            }
            

        }

    }
}

