namespace StrategyPattern
{
    /// <summary>
    /// The BusRouteCalculator calculates bus routes.
    /// </summary>
    public class BusRouteCalculator
    {
        /// <summary>
        /// The route algorithm used to determine routes.
        /// </summary>
        private readonly RouteAlgorithm _routeAlgorithm;

        /// <summary>
        /// The constructor sets the route algorithm that will be used to determine routes.
        /// </summary>
        /// <param name="routeAlgorithm">The route algorithm.</param>
        public BusRouteCalculator(RouteAlgorithm routeAlgorithm) { 
            _routeAlgorithm = routeAlgorithm;
        }

        /// <summary>
        /// Calculates and returns a route based on two given points.
        /// </summary>
        /// <param name="pointA">The starting point.</param>
        /// <param name="pointB">The ending point.</param>
        /// <returns>The route.</returns>
        public string CalculateBusRoute(string pointA, string pointB)
        {
            return _routeAlgorithm.CalculateRoute(pointA, pointB);
        }
    }
}
