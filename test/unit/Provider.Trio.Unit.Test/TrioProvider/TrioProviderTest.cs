using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Trio.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Trio.Unit.Test.TrioProvider
{
    public abstract class TrioProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ITrioClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected TrioProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ITrioClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Trio.TrioProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
