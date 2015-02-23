using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Psns.Common.Test.BehaviorDrivenDevelopment;

namespace BDD.UnitTests
{
    [TestClass]
    public class WhenWorkingWithBDDBase : BehaviorDrivenDevelopmentCaseTemplate
    {
        bool _arrangeWasCalled;
        bool _actWasCalled;

        public override void Arrange()
        {
            base.Arrange();

            _arrangeWasCalled = true;
        }

        public override void Act()
        {
            base.Act();

            _actWasCalled = true;
        }

        [TestMethod]
        public void ThenArrangeAndActShouldHaveBeenCalled()
        {
            Assert.IsTrue(_arrangeWasCalled);
            Assert.IsTrue(_actWasCalled);
        }
    }
}
