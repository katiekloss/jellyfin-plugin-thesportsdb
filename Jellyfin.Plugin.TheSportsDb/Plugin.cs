using Jellyfin.Plugin.TheSportsDb.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

public class Plugin : BasePlugin<PluginConfiguration>
{
    public override string Name { get; } = "TheSportsDB";
    public override Guid Id { get; } = new Guid("2132c109-9733-45eb-921e-353a2547ee6f");

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
    {
    }

}