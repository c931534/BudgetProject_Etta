using System;
using BudgetProject_Etta.Service;
using NUnit.Framework;

namespace BudgetProject_Etta.Tests.Service;

[TestFixture]
public class BudgetServiceTest
{
    private BudgetService _budgetService = new BudgetService();
    
    [Test]
    public void InvaildDateRange_should_be_0()
    {
        var result = _budgetService.Query(new DateTime(2024, 12, 01), new DateTime(2024, 11, 02));
        Assert.That(result, Is.EqualTo(0));
    }
}