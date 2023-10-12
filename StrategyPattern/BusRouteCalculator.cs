namespace StrategyPattern
{
    public class BusRouteCalculator
    {
        private readonly RouteAlgorithm _routeAlgorithm;

        public BusRouteCalculator(RouteAlgorithm routeAlgorithm) { 
            _routeAlgorithm = routeAlgorithm;
        }

        public string CalculateBusRoute(string pointA, string pointB)
        {
            return _routeAlgorithm.CalculateRoute(pointA, pointB);
        }
    }
}
