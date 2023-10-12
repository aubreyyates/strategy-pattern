namespace StrategyPattern.RouteAlgorithms
{
    public class Algorithm2 : RouteAlgorithm
    {
        public string CalculateRoute(string pointA, string pointB)
        {
            return pointA + " " + pointB + " route 2";
        }
    }
}
