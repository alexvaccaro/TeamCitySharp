using System;
using System.Collections.Generic;
using TeamCitySharp.Connection;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    public class BuildStats : IBuildStats
    {
        private readonly TeamCityCaller _caller;

        internal BuildStats(TeamCityCaller caller)
        {
            _caller = caller;
        }

        public Parameters ByBuildId(int buildId)
        {
            return ByBuildLocator(BuildLocator.WithId(buildId));
            //if (int.Parse(buildStats.Count) > 0)
            //{
            //    return buildWrapper.Build;
            //}
            //return new Parameters();
        }

        public Parameters ByBuildLocator(BuildLocator locator)
        {
            var buildStats = _caller.GetFormat<Parameters>("/app/rest/builds/{0}/statistics/", locator);
            return buildStats;
        }
    }
}