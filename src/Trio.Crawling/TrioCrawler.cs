using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Trio.Core;
using CluedIn.Crawling.Trio.Infrastructure.Factories;

namespace CluedIn.Crawling.Trio
{
    public class TrioCrawler : ICrawlerDataGenerator
    {
        private readonly ITrioClientFactory clientFactory;
        public TrioCrawler(ITrioClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is TrioCrawlJobData triocrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(triocrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
