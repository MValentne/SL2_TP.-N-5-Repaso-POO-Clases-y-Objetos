namespace MiNameSpace
{
    public static class ClaseGrados
    {
        private const double CeroAbsolutoCelsius = -273.15;
        private const double CeroAbsolutoFahrenheit = -459.67;

        public static double CelsiusAFahrenheit(double celsius)
        {
            ValidarCelsius(celsius);
            return celsius * 9 / 5 + 32;
        }

        public static double CelsiusAKelvin(double celsius)
        {
            ValidarCelsius(celsius);
            return celsius - CeroAbsolutoCelsius;
        }

        public static double FahrenheitACelsius(double fahrenheit)
        {
            ValidarFahrenheit(fahrenheit);
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double FahrenheitAKelvin(double fahrenheit)
        {
            return CelsiusAKelvin(FahrenheitACelsius(fahrenheit));
        }

        public static double KelvinACelsius(double kelvin)
        {
            ValidarKelvin(kelvin);
            return kelvin + CeroAbsolutoCelsius;
        }

        public static double KelvinAFahrenheit(double kelvin)
        {
            return CelsiusAFahrenheit(KelvinACelsius(kelvin));
        }

        private static void ValidarCelsius(double celsius)
        {
            if (celsius < CeroAbsolutoCelsius)
            {
                throw new ArgumentOutOfRangeException(nameof(celsius), "La temperatura no puede ser menor que el cero absoluto.");
            }
        }

        private static void ValidarKelvin(double kelvin)
        {
            if (kelvin < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kelvin), "La temperatura en Kelvin no puede ser negativa.");
            }
        }

        private static void ValidarFahrenheit(double fahrenheit)
        {
            if (fahrenheit < CeroAbsolutoFahrenheit)
            {
                throw new ArgumentOutOfRangeException(nameof(fahrenheit), "La temperatura no puede ser menor que el cero absoluto.");
            }
        }
    }
}
