using Microsoft.AspNetCore.Mvc;

namespace DBOperationsWithEFCoreApi.Services.Interfaces
{
    public interface ICurrencyService
    {
        Task<JsonResult> CurreniesGetService();
        Task<JsonResult> CurreniesGetByIdService(long Id);
    }
}
