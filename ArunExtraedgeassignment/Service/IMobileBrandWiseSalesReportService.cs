using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Service
{
    public interface IMobileBrandWiseSalesReportService
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
