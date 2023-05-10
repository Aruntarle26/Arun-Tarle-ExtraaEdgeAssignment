using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public interface IProfitLossRepository
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
