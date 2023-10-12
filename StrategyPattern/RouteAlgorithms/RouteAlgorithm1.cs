namespace StrategyPattern.RouteAlgorithms
{
    public class Algorithm1 : RouteAlgorithm
    {
        public string CalculateRoute(string pointA, string pointB)
        {
            return pointA + " " + pointB + " route 1";
        }
    }
}
