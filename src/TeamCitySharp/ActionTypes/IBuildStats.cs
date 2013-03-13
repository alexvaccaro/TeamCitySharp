using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    public interface IBuildStats
    {
        Parameters ByBuildId(int buildId);

        Parameters ByBuildLocator(BuildLocator locator);
    }
}