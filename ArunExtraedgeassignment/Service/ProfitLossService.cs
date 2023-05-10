using ArunExtraedgeassignment.Model;
using ArunExtraedgeassignment.Repository;

namespace ArunExtraedgeassignment.Service
{
    public class ProfitLossService : IProfitLossService
    {
        private readonly IProfitLossRepository repo;
        public ProfitLossService(IProfitLossRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate)
        {
            return repo.GetProfitLossReport(fromDate,toDate);
        }
    }
}
