﻿namespace StrategyPattern.RouteAlgorithms
{
    /// <summary>
    /// The RouteAlgorithm1 class is an algorithm for determining routes.
    /// </summary>
    public class RouteAlgorithm1 : RouteAlgorithm
    {
        /// <summary>
        /// Calculates and returns a route based on two given points.
        /// </summary>
        /// <param name="pointA">The starting point.</param>
        /// <param name="pointB">The ending point.</param>
        /// <returns>The route.</returns>
        public string CalculateRoute(string pointA, string pointB)
        {
            return pointA + ", " + pointB + " - route 1";
        }
    }
}
