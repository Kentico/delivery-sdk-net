﻿using Kentico.Kontent.Delivery.Abstractions;
using System.Threading.Tasks;

namespace Kentico.Kontent.Delivery.ContentItems.ContentLinks
{
    internal class DefaultContentLinkUrlResolver : IContentLinkUrlResolver
    {
        public Task<string> ResolveLinkUrl(IContentLink link) 
            => Task.FromResult<string>(null);

        public Task<string> ResolveBrokenLinkUrl()
            => Task.FromResult<string>(null);
    }
}
