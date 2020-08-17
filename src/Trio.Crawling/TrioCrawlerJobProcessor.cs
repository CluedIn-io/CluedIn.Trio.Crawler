using CluedIn.Crawling.Trio.Core;

namespace CluedIn.Crawling.Trio
{
    public class TrioCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<TrioCrawlJobData>
    {
        public TrioCrawlerJobProcessor(TrioCrawlerComponent component) : base(component)
        {
        }
    }
}
