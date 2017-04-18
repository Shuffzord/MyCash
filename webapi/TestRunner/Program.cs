using System;
using System.Reflection;
using MyCashApiTest;
using NUnit.Common;
using NUnitLite;

namespace TestRunner
{
  class Program
  {
    public static int Main(string[] args)
    {
      return new AutoRun(typeof(TimeCalculationTest).GetTypeInfo().Assembly)
       .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
    }
  }
}