using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Psns.Common.Test.BehaviorDrivenDevelopment
{
    /// <summary>
    /// Base class to enable Arrange-Act-Assert pattern
    /// </summary>
    public abstract class BehaviorDrivenDevelopmentCaseTemplate
    {
        /// <summary>
        /// Constructor will call Arrange and Act in order
        /// </summary>
        public BehaviorDrivenDevelopmentCaseTemplate()
        {
            Arrange();
            Act();
        }

        /// <summary>
        /// Arrange all necessary pre-conditions and inputs
        /// </summary>
        public virtual void Arrange() { return; }

        /// <summary>
        /// Act on the object or method under test
        /// </summary>
        public virtual void Act() { return; }

        /// <summary>
        /// Free/Reset any Disposable resources
        /// </summary>
        public virtual void CleanUp() { return; }
    }
}
