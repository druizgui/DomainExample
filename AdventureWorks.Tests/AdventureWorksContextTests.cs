// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace AdventureWorks.Tests
{
    using System;
    using System.Linq;
    using AdventureWorks.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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