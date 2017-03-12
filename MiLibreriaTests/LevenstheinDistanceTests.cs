using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiLibreria;

namespace MiLibreriaTests
{
    [TestClass]
    public class LevenstheinDistanceTests
    {
        [TestMethod]
        public void XamarinAndCamarin_ShouldReturn1()
        {
            // Arrange
            var cadena1 = "xamarin";
            var cadena2 = "camarin";
            int resultadoEsperado = 1;
            LevenshteinDistance calculator = new LevenshteinDistance();

            // Act
            var result = calculator.Compute(cadena1, cadena2);

            // Assert
            Assert.AreEqual(resultadoEsperado, result);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullAndCamarin_ShouldThrowExcepion()
        {
            // Arrange
            string cadena1 = null;
            var cadena2 = "camarin";
            LevenshteinDistance calculator = new LevenshteinDistance();

            // Act
            calculator.Compute(cadena1, cadena2);

            // Assert
            // Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
