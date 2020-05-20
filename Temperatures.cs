namespace TemperatureConverter
{
    /// <summary>
    /// Contains static methods to convert between temperature scales.
    /// Float chosen as data types as accuracy not needed for this app.
    /// </summary>
    public class Temperatures
    {
        private string choiceMade;
        private float fromTemp;
        private float convertedTempResult;
        public float ConvertedTempResult 
        {
            get
            {
                return convertedTempResult;
            }
        }

        public Temperatures(string selectedChoice, float fromTemperature)
        {
            this.choiceMade = selectedChoice;
            this.fromTemp = fromTemperature;
        }

        public void DoConversion()
        {
            switch (choiceMade)
            {
                case "1": // celcius to fahrenheit
                    convertedTempResult = ((fromTemp * 9/5) + 32);
                    break;
                case "2": // celcius to kelvin
                    convertedTempResult = fromTemp + 273.15f;
                    break;
                case "3": // fahrenheit to celsius
                    convertedTempResult = ((fromTemp -32) * 5/9);
                    break;
                case "4": // fahrenheit to kelvin
                    convertedTempResult = ((fromTemp + 459.67f) * (5/9));
                    break;
                case "5": // kelvin to celsius
                    convertedTempResult = fromTemp - 273.15f;
                    break;
                case "6": // kelvin to fahrenheit
                    convertedTempResult = ((fromTemp * 9/5) - 459.67f);
                    break;
            }
        }
    }
}