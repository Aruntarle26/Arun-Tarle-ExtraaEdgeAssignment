﻿using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public interface ISalesReportReository
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
