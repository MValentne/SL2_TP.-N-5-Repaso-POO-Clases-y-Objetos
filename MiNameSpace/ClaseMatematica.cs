namespace MiNameSpace
{
    /// <summary>
    /// Agrupa operaciones matematicas habituales.
    /// </summary>
    public static class ClaseMatematica
    {
        public static double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }

        public static double Potencia(double baseNumero, double exponente)
        {
            return Math.Pow(baseNumero, exponente);
        }

        public static double RaizCuadrada(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numero), "La raiz cuadrada no esta definida para numeros negativos.");
            }

            return Math.Sqrt(numero);
        }

        public static double Seno(double anguloEnGrados)
        {
            return Math.Sin(GradosARadianes(anguloEnGrados));
        }

        public static double Exponencial(double exponente)
        {
            return Math.Exp(exponente);
        }

        private static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180;
        }
    }
}
