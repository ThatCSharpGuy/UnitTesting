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
        public void FluentAssertionsDemo_ShouldContainJava()
        {
            string result = "That C# guy";
            result.Should().StartWith("That").And.EndWith("guy").And.Contain("Java");
        }

        [TestMethod]
        public void FluentAssertionsDemo_ShouldHave8Characters()
        {
            string result = "That C# guy";
            result.Should().HaveLength(8, "because I love the number 8");
        }

        [TestMethod]
        public void Demo_ShouldHave8Characters()
        {
            string actual = "That C# guy";
            Assert.AreEqual(8, actual.Length);
        }

        [TestMethod]
        public void FluentAssertions_ShouldHave3Integers()
        {
            var array = new int[] { 10, 5 };
            array.Should().HaveCount(3);
        }

        [TestMethod]
        public void FluentAssertions_ShouldContain2Fives()
        {
            object array = new int[] { 10, 5, 5 };
            array.Should().BeOfType<int[]>()
                .Which.Should().HaveCount(10, "some weird reason");
        }

        [TestMethod]
        public void FluentAssertions_ShouldHave3IntegersWithMessage()
        {
            var array = new int[] { 10, 5 };
            array.Should().HaveCount(3, "because I wanted this to fail");
        }

        [TestMethod]
        public void Division1Over0_ShouldThrowException()
        {
            Action action = () =>
            {
                var i = 1;
                var t = 1 / (i - 1);
            };

            action.ShouldThrow<FormatException>("other reason");
        }

        [TestMethod]
        public void Dictionary_ShouldContain()
        {
            var computerScientists = new Dictionary<string, string>();

            computerScientists.Should()
                .ContainValue("Grace Hopper", "she's awesome")
                .Which.Length.Should().Be(12);
        }
    }
}
