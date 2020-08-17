using CluedIn.Crawling.Trio.Core;

namespace CluedIn.Crawling.Trio.Infrastructure.Factories
{
    public interface ITrioClientFactory
    {
        TrioClient CreateNew(TrioCrawlJobData trioCrawlJobData);
    }
}
