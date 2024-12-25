using System;
using BudgetProject_Etta.Service;
using NUnit.Framework;

namespace BudgetProject_Etta.Tests.Service;

[TestFixture]
public class BudgetServiceTest
{

    [Test]
    public void InvaildDateRange_should_be_0()
    {
        var startDate = new DateTime(2024, 12, 01);
        var endDate = new DateTime(2024, 11, 02);
        var service = new BudgetService();
        var result = service.Query(startDate, endDate);
        Assert.That(result, Is.EqualTo(0));
    }
}