namespace TemperatureConverter
{
    /// <summary>
    /// Contains static methods to convert between temperature scales
    /// Float chosen as data types as accuracy not needed for this app.
    /// </summary>
    public class Temperatures
    {
        public static float CelciusToFahrenheit(float celcius)
        {
            return ((celcius * 9/5) + 32); // Temp in Fahrenheit
        }

        public static float CelciusToKelvin(float celcius)
        {
            return celcius + 273.15f; // Temp in Kelvin
        }

        public static float FahrenheitToCelcius(float fahrenheit)
        {
            return ((fahrenheit -32) * 5/9); // Temp in Celcius
        }

        public static float FahrenheitToKelvin(float fahrenheit)
        {
            return ((fahrenheit + 459.67f) * (5/9)); // Temp in kelvin
        }

        public static float KelvinToCelcius(float kelvin)
        {
            return kelvin - 273.15f; // Temp in Celcius
        }

        public static float KelvinToFahrenheit(float kelvin)
        {
            return ((kelvin * 9/5) - 459.67f); // Temp in fahrenheit
        }
    }
}