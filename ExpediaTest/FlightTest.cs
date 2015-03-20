using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
    [TestFixture()]
    public class FlightTest
    {
        //TODO Task 7 items go here
        [Test()]
        public void TestFlightInit()
        {
            var target = new Flight(new DateTime(2015, 3, 21), new DateTime(2015, 3, 31), 100);
            Assert.IsNotNull(target);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightForcesStartDateToBeBeforeEndDate()
        {
            new Flight(new DateTime(2015, 3, 31), new DateTime(2015, 3, 21), 100);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightMilesMustBePositive()
        {
            new Flight(new DateTime(2015, 3, 21), new DateTime(2015, 3, 31), -5);
        }

        [Test()]
        public void TestCorrectBasePriceForOneDay()
        {
            var target = new Flight(new DateTime(2015, 3, 20), new DateTime(2015, 3, 21), 100);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestCorrectBasePriceForFiveDays()
        {
            var target = new Flight(new DateTime(2015, 4, 1), new DateTime(2015, 4, 6), 100);
            Assert.AreEqual(300, target.getBasePrice());
        }

    }

}
