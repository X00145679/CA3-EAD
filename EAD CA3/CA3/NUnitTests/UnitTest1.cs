using Bunit;
using CA3;
using CA3.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NUnitTests
{
    [TestClass]
    public class Tests
    {
        private Bunit.TestContext testContext;
        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();
        }

        [TearDown]
        public void Teardown()
        {
            testContext.Dispose();
        }

        [TestMethod]
        public void TestReviewsComponent()
        {
            var cut = testContext.RenderComponent<Reviews>();
            NUnit.Framework.Assert.IsNotNull(cut);
        }

        [TestMethod]
        public void TestDispose()
        {
            var cut = testContext.RenderComponent<Reviews>();
            cut.Dispose();
            NUnit.Framework.Assert.IsTrue(cut.IsDisposed);
        }

        [TestMethod]
        public void TestHomeComponent()
        { 
            var cut = testContext.RenderComponent<Home>();
            NUnit.Framework.Assert.IsNotNull(cut);
        }
    }
}