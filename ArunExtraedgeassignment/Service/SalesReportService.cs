using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Repository;

namespace ArunExtraedgeassignment.Service
{
    public class SalesReportService : ISalesReportService
    {
        private readonly ISalesReportReository repo;
        public SalesReportService(ISalesReportReository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            return repo.GetSalesMonthlyReport(fromDate, toDate);
        }
    }
}
