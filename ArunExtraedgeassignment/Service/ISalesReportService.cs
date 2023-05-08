using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Service
{
    public interface ISalesReportService
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
