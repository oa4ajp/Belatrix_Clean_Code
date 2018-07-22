using System;

namespace SOLID._05_Dependency_Inversion
{
    public interface IWeatherAlert
    {
        String GenerateWeatherAlert(String weatherConditions);
    }
}
