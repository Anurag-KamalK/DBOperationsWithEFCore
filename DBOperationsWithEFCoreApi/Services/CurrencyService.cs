using System;
using DBOperationsWithEFCoreApi.Data;
using DBOperationsWithEFCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApi.Services
{
    public class CurrencyService:ICurrencyService
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<JsonResult> CurreniesGetService()
        {
            //var result = await _appDbContext.Currencies.ToListAsync();
            //var result = await (from currecies in _appDbContext.Currencies select currecies).ToListAsync();

            var result = await (
                _appDbContext.Currencies
                .OrderByDescending(cur => cur.Id).Take(3)
                .Select(cur => new
                {
                    cur.Id,
                    cur.currency,
                    cur.description

                })).ToListAsync();

            return new JsonResult(result);
        }

        public async Task<JsonResult> CurreniesGetByIdService(long Id)
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
