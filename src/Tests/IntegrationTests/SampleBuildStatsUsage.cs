using System;
using System.Net;
using NUnit.Framework;

namespace TeamCitySharp.IntegrationTests
{
    [TestFixture]
    public class when_interacting_to_get_stats
    {
        private ITeamCityClient _client;

        [SetUp]
        public void SetUp()
        {
            _client = new TeamCityClient("londbcnab01");
            _client.Connect("demo", "demo");
            //_client = new TeamCityClient("teamcity.codebetter.com");
            //_client.Connect("teamcitysharpuser", "qwerty");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void it_throws_exception_when_no_url_passed()
        {
            new TeamCityClient(null);
        }

        [Test]
        public void it_returns_stats_by_build_id()
        {
            const int buildId = 255121;
            var stats = _client.BuildStats.ByBuildId(buildId);

            Assert.That(stats != null, "No successful builds have been found");
        }
    }
}
