using BudgetProject_Etta.Repository;

namespace BudgetProject_Etta.Service;

public class BudgetService
{
   
    public decimal Query(DateTime startDate, DateTime endDate)
    {
        // 判斷結束日期是否早於開始日期
        if (endDate < startDate)
        {
            return 0;
        }
        return -1;
    }
}