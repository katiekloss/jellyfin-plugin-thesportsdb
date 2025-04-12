using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

public class TheSportsDbExternalId : IExternalId
{
    public string ProviderName => Constants.ProviderName;

    public string Key => Constants.ProviderName;

    public ExternalIdMediaType? Type => null;

    // probably fine for now, unless this gets reused for identifying seasons or leagues or whatevs
    public string? UrlFormatString => "https://www.thesportsdb.com/event/{0}";

    // until/unless we have a custom type
    public bool Supports(IHasProviderIds item) => item is Episode;
}