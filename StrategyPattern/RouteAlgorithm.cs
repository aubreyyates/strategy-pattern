namespace StrategyPattern
{
    /// <summary>
    /// The RouteAlgorithm interface provides a way to use route algorithms.
    /// </summary>
    public interface RouteAlgorithm
    {
        /// <summary>
        /// Calculates and returns a route based on two given points.
        /// </summary>
        /// <param name="pointA">The starting point.</param>
        /// <param name="pointB">The ending point.</param>
        /// <returns>The route.</returns>
        public string CalculateRoute(string pointA, string pointB);
    }
}
