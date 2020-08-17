using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Trio;
using CluedIn.Crawling.Trio.Infrastructure.Factories;
using Moq;
using Should;
using Xunit;

namespace Crawling.Trio.Unit.Test
{
    public class TrioCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public TrioCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ITrioClientFactory>();

            _sut = new TrioCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
