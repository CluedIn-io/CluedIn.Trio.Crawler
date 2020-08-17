using System.Collections.Generic;
using CluedIn.Crawling.Trio.Core;

namespace CluedIn.Crawling.Trio.Integration.Test
{
  public static class TrioConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { TrioConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
