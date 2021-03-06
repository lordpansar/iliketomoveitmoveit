using MoveIT.API.Services;
using System;
using Xunit;

namespace MoveIT.Test
{
    public class PriceCalculation
    {
        OfferService offerService;

        public PriceCalculation()
        {
            offerService = new OfferService();
        }

        [Theory]
        [InlineData(0.0, 1000)]
        [InlineData(10.0, 1100)]
        [InlineData(49.9, 1499)]
        [InlineData(50.0, 5400)]
        [InlineData(51.0, 5408)]
        [InlineData(99.0, 5792)]
        [InlineData(100.0, 10700)]
        public void AssertThatDistancePriceIsCalculatedCorrectly(double distance, double expectedPrice)
        {
            var price = offerService.CalculateDistancePrice(distance);
            Assert.Equal(expectedPrice, price);
        }

        [Fact]
        public void AssertThatNegativeDistanceIsCaught()
        {
            var distance = -1;
            var price = offerService.CalculateDistancePrice(distance);
            Assert.Equal(0, price);
        }

        [Theory]
        [InlineData(49, 0, 1)]
        [InlineData(10, 25, 2)]
        [InlineData(50, 0, 2)]
        [InlineData(100, 0, 3)]
        [InlineData(150, 0, 4)]
        public void AssertThatNumberOfCarsIsCalculatedCorrectly(double livingArea, double auxArea, int expected)
        {
            var actual = offerService.CalculateNumberOfCars(livingArea, auxArea);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AssertThatNegativeCarsIsCaught()
        {
            var livingArea = -1;
            var auxArea = 0;

            var cars = offerService.CalculateNumberOfCars(livingArea, auxArea);
            Assert.Equal(0, cars);
        }

        [Theory]
        [InlineData(true, 5000)]
        [InlineData(false, 0)]
        public void AssertThatPianoCostIsCalculatedCorrectly(bool offerHasPiano, int expected)
        {
            var actual = offerService.CalculatePianoCost(offerHasPiano);
            Assert.Equal(expected, actual);
        }
    }
}
