﻿using System;

namespace MvcSiteMapProvider
{
    public interface ISiteMapSettings
    {
        string SiteMapCacheKey { get; set; }
        string SiteMapResourceName { get; set; }
        bool SecurityTrimmingEnabled { get; }
        bool EnableLocalization { get; }
        bool VisibilityAffectsDescendants { get; }
        bool UseTitleIfDescriptionNotProvided { get; }
    }
}
