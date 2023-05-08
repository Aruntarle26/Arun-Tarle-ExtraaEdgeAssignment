using ArunExtraedgeassignment.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArunExtraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReportController : ControllerBase
    {
        private readonly ISalesReportService service;
        public SalesReportController(ISalesReportService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetSalesMonthlyReport")]
        public IActionResult GetSalesMonthlyReport(DateTime fromDate,DateTime toDate)
        {
            try
            {
                return new ObjectResult(service.GetSalesMonthlyReport(fromDate,toDate));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
