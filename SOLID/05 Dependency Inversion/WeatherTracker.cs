using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        String currentConditions;
        IWeatherAlert _weatherAlert;

        public WeatherTracker(IWeatherAlert weatherAlert)
        {
            _weatherAlert = weatherAlert;
        }

        public string SetCurrentConditions(String weatherDescription)
        {
            this.currentConditions = weatherDescription;

            String alert = _weatherAlert.GenerateWeatherAlert(weatherDescription);
            Console.WriteLine(alert);
            return alert;
        }
    }
}
