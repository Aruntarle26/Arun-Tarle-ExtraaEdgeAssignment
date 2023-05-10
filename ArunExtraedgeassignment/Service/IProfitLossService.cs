using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Service
{
    public interface IProfitLossService
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
