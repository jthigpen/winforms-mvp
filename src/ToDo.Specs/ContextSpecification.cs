using System;
using NUnit.Framework;

namespace ToDo.Specs
{
    [TestFixture]
    [Concern(typeof(UnspecifiedConcern))]
    public abstract class ContextSpecification
    {
        protected Exception ThrownException = null;

        [SetUp]
        public void SetUp()
        {
            EstablishContext();
            ThrownException = Capture.Exception(Because);
        }

        [TearDown]
        public void TearDown()
        {
            AfterEachSpecification();
        }

        protected abstract void Because();
        protected abstract void EstablishContext();

        protected virtual void AfterEachSpecification()
        { }
    }
}