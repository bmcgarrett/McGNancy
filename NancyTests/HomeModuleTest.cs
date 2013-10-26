using System;
using System.IO;
using System.Linq;
using Nancy.Testing;
using Nancy;
using NancyApp;
using NUnit.Framework;
using HttpStatusCode = Nancy.HttpStatusCode;

namespace NancyTests
{
    [TestFixture]
    public class HomeModuleTest
    {
        [Test]
        public void Should_return_status_ok_when_route_exists()
        {
            // Given
            var boostrapper = new ConfigurableBootstrapper(with =>
            {
                with.Module<HomeModule>();
            });

            var browser = new Browser(boostrapper);

            // When
            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            // Then
            Assert.AreEqual(HttpStatusCode.OK,result.StatusCode);


        }
    }
}
