namespace MyLib
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate area of a figure
        /// </summary>
        /// <param name="figure">an instance of a class that implements an interface MyLib.Figure</param>
        /// <returns>area of a figure</returns>
        public static double CalculateArea(Figure figure)
        {
            return figure.CalculateArea();
        }
    }
}
