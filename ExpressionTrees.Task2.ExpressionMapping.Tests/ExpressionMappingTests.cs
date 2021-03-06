using ExpressionTrees.Task2.ExpressionMapping.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionTrees.Task2.ExpressionMapping.Tests
{
    [TestClass]
    public class ExpressionMappingTests
    {
        // todo: add as many test methods as you wish, but they should be enough to cover basic scenarios of the mapping generator

        [TestMethod]
        public void TestMethod1()
        {
            var mapGenerator = new MappingGenerator();
            var mapper = mapGenerator.Generate<Foo, Bar>();
            var foo = new Foo
            {
                ID = "123i456f2334fd",
                Weight = 15
            };

            var res = mapper.Map(foo);

            Assert.AreEqual(res.ID, foo.ID);
            Assert.AreEqual(res.Weight, foo.Weight);
        }
    }
}
