// <copyright file="TestingMiscTest001.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong3.Patterns;

namespace PingPong3.Patterns.Tests
{
    [TestClass]
    [PexClass(typeof(TestingMisc))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TestingMiscTest
    {
    }
}
