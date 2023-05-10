using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Repository;

namespace ArunExtraedgeassignment.Service
{
    public class MobileBrandWiseSalesReportService : IMobileBrandWiseSalesReportService
    {
        private readonly IMobilebrandWiseSalesReportRepository repo;
        public MobileBrandWiseSalesReportService(IMobilebrandWiseSalesReportRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate)
        {
            return repo.MobilebrandWiseSalesReport(fromDate,toDate);
        }
    }
}
