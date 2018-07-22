using System;

namespace SOLID._05_Dependency_Inversion
{
    public class Emailer : IWeatherAlert
    {
        public String GenerateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }
}
