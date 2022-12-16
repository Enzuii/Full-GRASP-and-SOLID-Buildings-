/* //--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Full_GRASP_And_SOLID.Library;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Prueba de la clase <see cref="Train"/>.
    /// </summary>
    [TestFixture]
    public class TrainTests
    {
        /// <summary>
        /// Prueba del método <see cref="Train.GetTotalCost"/>.
        /// </summary>
        [Test]
        public void GetTotalCostTest()
        {
            // Arrange
            Train train = new Train();
            Step step1 = new Step(1, "Step 1", 10, 10);
            Step step2 = new Step(2, "Step 2", 20, 20);
            train.AddStep(step1);
            train.AddStep(step2);

            // Act
            double totalCost = train.GetTotalCost();

            // Assert
            Assert.AreEqual(600, totalCost);
        }
    }
} */