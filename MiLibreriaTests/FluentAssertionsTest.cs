using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiLibreriaTests
{
    [TestClass]
    public class FluentAssertionsTest
    {

        [TestMethod]
        public void FluentAssertions_First()
        {
            string result = "That C# guy";
            result.Should().StartWith("That").And.EndWith("guy").And.Contain("Java");
        }

        [TestMethod]
        public void Normal_First()
        {
            string result = "That C# guy";

            Assert.IsTrue(result.StartsWith("That"));
            Assert.IsTrue(result.EndsWith("guy"));
            Assert.IsTrue(result.Contains("Java"));
        }

        [TestMethod]
        public void FluentAssertions_StringShouldHave8Characters()
        {
            string result = "That C# guy";
            result.Should().HaveLength(8, "because I love the number 8");
        }

        [TestMethod]
        public void Normal_StringShouldHave8Characters()
        {
            string actual = "That C# guy";
            Assert.AreEqual(8, actual.Length);
        }

        [TestMethod]
        public void FluentAssertions_ArrayShouldHave3Integers()
        {
            var array = new int[] { 10, 5 };
            array.Should().HaveCount(3);
        }

        [TestMethod]
        public void Normal_ArrayShouldHave3Integers()
        {
            var array = new int[] { 10, 5 };
            Assert.AreEqual(3, array.Length);
        }

        [TestMethod]
        public void FluentAssertions_ShouldBeArrayWith10Elements()
        {
            object array = new int[] { 10, 5, 5 };
            array.Should().BeOfType<int[]>()
                .Which.Should().HaveCount(10, "some weird reason");
        }

        [TestMethod]
        public void Normal_ShouldBeArrayWith10Elements()
        {
            object thing = new int[] { 10, 5, 5 };

            var arreglo = thing as int[];
            Assert.IsNotNull(arreglo);
            Assert.AreEqual(10, arreglo.Length);
        }

        [TestMethod]
        public void FluentAssertions_ShouldThrowException()
        {
            Action action = () =>
            {
                var i = 1;
                var t = 1 / (i - 1);
            };
            action.ShouldThrow<FormatException>("other reason");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Normal_ShouldThrowException()
        {
            Action action = () =>
            {
                var i = 1;
                var t = 1 / (i - 1);
            };
            action();
        }

        [TestMethod]
        public void FluentAssertions_DictionaryShouldContain()
        {
            var computerScientists = new Dictionary<string, string>();

            computerScientists.Should()
                .ContainValue("Grace Hopper", "she's awesome")
                .Which.Length.Should().Be(12);
        }

        [TestMethod]
        public void Normal_DictionaryShouldContain()
        {
            var computerScientists = new Dictionary<string, string>();
            
            Assert.IsTrue(computerScientists.ContainsValue("Grace Hopper"));
            var value = computerScientists["Grace Hopper"];
            Assert.AreEqual(12, value.Length);
        }
    }
}
