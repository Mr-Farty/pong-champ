//// <copyright file="TestingMiscTest.cs">Copyright ©  2017</copyright>
//using System;
//using Microsoft.Pex.Framework;
//using Microsoft.Pex.Framework.Validation;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PingPong3.Patterns;

//namespace PingPong3.Patterns.Tests
//{
//    /// <summary>This class contains parameterized unit tests for TestingMisc</summary>
//    [PexClass(typeof(TestingMisc))]
//    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
//    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
//    [TestClass]
//    public partial class TestingMiscTest
//    {
//        /// <summary>Test stub for GenerateBallVelocityX()</summary>
//        [PexMethod]
//        public int GenerateBallVelocityXTest([PexAssumeUnderTest]TestingMisc target)
//        {
//            int result = target.GenerateBallVelocityX();
//            return result;
//            // TODO: add assertions to method TestingMiscTest.GenerateBallVelocityXTest(TestingMisc)
//        }
//    }
//}
