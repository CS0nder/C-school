const int spdOfLightInMperS = 997924528;
const double daysInYear = 365.242199;
const string planetName = "LP 890-9b";
const double distanceFromEarthInLightYear = 100;

double InMeters = distanceFromEarthInLightYear * spdOfLightInMperS * 60 * 60 * 24 * daysInYear;

Console.WriteLine($"The planet {planetName} is {distanceFromEarthInLightYear} lightyears away from Earth");
Console.WriteLine($" In meters this is {InMeters}");

