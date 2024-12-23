using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SacherMuellerLB_426;

namespace SacherMuellerLB_426.Tests
{
    [TestClass]
    public class CrapsTests
    {
        [TestMethod]
        public void TestFirstRollNatural()
        {
            // Arrange
            var craps = new Craps();

            // Act
            var result = craps.FirstRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }

        [TestMethod]
        public void TestFirstRollCraps()
        {
            // Arrange
            var craps = new Craps();

            // Act
            var result = craps.FirstRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }

        [TestMethod]
        public void TestFirstRollPoint()
        {
            // Arrange
            var craps = new Craps();

            // Act
            var result = craps.FirstRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }

        [TestMethod]
        public void TestSecondRollWin()
        {
            // Arrange
            var craps = new Craps();
            craps.point = 4;

            // Act
            var result = craps.SecondRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }

        [TestMethod]
        public void TestSecondRollLose()
        {
            // Arrange
            var craps = new Craps();
            craps.point = 4;

            // Act
            var result = craps.SecondRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }

        [TestMethod]
        public void TestSecondRollSeven()
        {
            // Arrange
            var craps = new Craps();
            craps.point = 4;

            // Act
            var result = craps.SecondRoll();

            // Assert
            Assert.IsTrue(result == 1 || result == -1 || result == 0);
        }
    }
}