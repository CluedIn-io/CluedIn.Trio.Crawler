using CluedIn.Core;
using CluedIn.Crawling.Trio.Core;

using ComponentHost;

namespace CluedIn.Crawling.Trio
{
    [Component(TrioConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class TrioCrawlerComponent : CrawlerComponentBase
    {
        public TrioCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

