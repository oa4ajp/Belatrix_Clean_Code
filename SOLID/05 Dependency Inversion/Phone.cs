using System;

namespace SOLID._05_Dependency_Inversion
{
    public class Phone : IWeatherAlert
    {
        public String GenerateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }
}
