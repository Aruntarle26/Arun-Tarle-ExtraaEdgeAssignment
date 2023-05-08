using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public interface ISalesReportReository
    {
        IEnumerable<SalesReport> GetSalesReportByBrand(DateTime fromDate, DateTime toDate);
    }
}
