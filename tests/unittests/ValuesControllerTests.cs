using System;
using System.Linq;
using src.Controllers;
using Xunit;

namespace UnitTests
{
    public class ValuesControllerTests
    { 
        private readonly ValuesController controller;
        public ValuesControllerTests()
        {
            this.controller = new ValuesController();
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

                [Fact]
        public void Test2()
        {
            var values = this.controller.Get();
            Assert.True(values.Value.Count() == 2);           
        }
    }
}
