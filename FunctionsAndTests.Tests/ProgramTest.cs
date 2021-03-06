// <copyright file="ProgramTest.cs">Copyright ©  2016</copyright>
using System;
using FunctionsAndTests;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionsAndTests.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        /// <summary>Test stub for calculatePrice(Double, Double)</summary>
        [PexMethod]
        internal decimal calculatePriceTest(
            [PexAssumeUnderTest]Program target,
            double width,
            double length
        )
        {
            decimal result = target.calculatePrice(width, length);
            a
            return result;
            // TODO: add assertions to method ProgramTest.calculatePriceTest(Program, Double, Double)
        }
    }
}
