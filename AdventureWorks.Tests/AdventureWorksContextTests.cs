using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Tests
{
    using System;
    using System.Linq;
    using AdventureWorks.Data;

    [TestClass]
    public class AdventureWorksContextTests
    {
        [TestMethod]
        public void People_Count()
        {
            var uow = new AdventureWorksContext();

            var totalPeople = uow.Person.Count();
            Console.WriteLine($"totalPeople: {totalPeople}");

            Assert.IsNotNull(totalPeople);
        }
    }
}
