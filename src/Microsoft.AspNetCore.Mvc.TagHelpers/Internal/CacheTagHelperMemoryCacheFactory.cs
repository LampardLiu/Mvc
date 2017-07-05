// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Mvc.TagHelpers.Internal
{
    public class CacheTagHelperMemoryCacheFactory
    {
        internal static readonly string MemoryCacheOptionsName = typeof(CacheTagHelper).FullName;

        public CacheTagHelperMemoryCacheFactory(IOptions<CacheTagHelperOptions> options)
        {
            Cache = new MemoryCache(new MemoryCacheOptions
            {
                //HighWatermark = options.Value.MaxSize
            });
        }

        // For testing only.
        internal CacheTagHelperMemoryCacheFactory(IMemoryCache cache)
        {
            Cache = cache;
        }

        public IMemoryCache Cache { get; }
    }
}
