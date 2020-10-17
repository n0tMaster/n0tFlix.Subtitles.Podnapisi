using System;
using System.Collections.Generic;
using n0tFlix.Subtitles.Podnapisi.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace n0tFlix.Subtitles.Podnapisi
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        public override string Name => "Podnapisi Subtitles";

        public override Guid Id => Guid.Parse("623de0a4-863a-440b-b35c-5d787c575a9d");

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public static Plugin Instance { get; private set; }


    }
}
