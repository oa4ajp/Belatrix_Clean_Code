using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID._05_Dependency_Inversion;
using FluentAssertions;
using Xunit;

namespace SOLIDPrinciples.Tests
{
    [TestClass]
    public class DependencyInversionTests
    {
        [TestMethod]
        public void Validate_Email_Alert()
        {
            string weatherDescription = "sunny";
            var weatherTracker = new WeatherTracker(GetWeatherAlert(weatherDescription));
            weatherTracker.SetCurrentConditions(weatherDescription).Should().Be("It is " + weatherDescription);
        }

        [TestMethod]
        public void Validate_Phone_Alert()
        {
            string weatherDescription = "rainy";
            var weatherTracker = new WeatherTracker(GetWeatherAlert(weatherDescription));
            weatherTracker.SetCurrentConditions(weatherDescription).Should().Be("It is " + weatherDescription); ;
        }

        private IWeatherAlert GetWeatherAlert(string weatherDescription)
        {
            if (weatherDescription == "rainy")
            {
                return new Phone();
            }
            else if (weatherDescription == "sunny")
            {
                return new Emailer();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
