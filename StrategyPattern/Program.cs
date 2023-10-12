using StrategyPattern;
using StrategyPattern.RouteAlgorithms;

// Instantiate a BusRouteCalculator that uses RouteAlgorithm1 to calculate bus routes.
BusRouteCalculator busRouteCalculator = new BusRouteCalculator(new RouteAlgorithm1());

// Prints "The bus stop, The mall - route 1".
Console.WriteLine(busRouteCalculator.CalculateBusRoute("The bus stop", "The mall"));

// Change the route algorithm to use in the BusRouteCalculator. This will change the algorithm used without needing to
// change the BusRouteCalculator.
busRouteCalculator = new BusRouteCalculator(new RouteAlgorithm2());

// Prints "The bus stop, The mall - route 2".
Console.WriteLine(busRouteCalculator.CalculateBusRoute("The bus stop", "The mall"));