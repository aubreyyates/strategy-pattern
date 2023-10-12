namespace StrategyPattern.RouteAlgorithms
{
    public class RouteAlgorithm2 : RouteAlgorithm
    {
        public string CalculateRoute(string pointA, string pointB)
        {
            return pointA + ", " + pointB + " - route 2";
        }
    }
}
