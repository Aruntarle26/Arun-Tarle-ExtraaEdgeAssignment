using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public interface IMobilebrandWiseSalesReportRepository
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
