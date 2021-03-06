﻿using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using MyCashApi;
using MyCashApi.Helpers;
using Interval = MyCashApi.Enums.Interval;
namespace MyCashApiTest
{
  [TestFixture]
  public class TimeCalculationTest
  {
    public class TestData
    {
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }

      public Interval Interval { get; set; }
      public int ExpectedResult { get; set; }
    }

    private static readonly TestData[] _testData = {
      new TestData
      {
          StartDate= new DateTime(2017,1,8),
          EndDate= new DateTime(2017,3,13),
          Interval = Interval.Monthly,
          ExpectedResult = 2
      }
      ,new TestData
      {
          StartDate= new DateTime(2017,1,8),
          EndDate= new DateTime(2018,3,13),
          Interval = Interval.Yearly,
          ExpectedResult = 1
      }
      ,new TestData
      {
          StartDate= new DateTime(2017,1,8),
          EndDate= new DateTime(2018,2,13),
          Interval = Interval.Monthly,
          ExpectedResult = 13
      },
    };

    [Test]
    public void DateDifferenceFromNowTest([ValueSource("_testData")]TestData calculationTestData)
    {
      Assert.AreEqual(calculationTestData.ExpectedResult, TimeCalculationService.DateDifferenceFrom(calculationTestData.StartDate, calculationTestData.Interval, calculationTestData.EndDate));
    }
  }
}
