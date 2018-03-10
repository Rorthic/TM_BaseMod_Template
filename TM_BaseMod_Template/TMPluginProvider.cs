using StudioForge.TotalMiner.API;

namespace Skylands
{
    class TMPluginProvider : ITMPluginProvider
    {
        public ITMPlugin GetPlugin()
        {
            return new Skyland();
        }

        public ITMPluginBlocks GetPluginBlocks()
        {
            return null;
        }

        public ITMPluginArcade GetPluginArcade()
        {
            return null;
        }

        public ITMPluginGUI GetPluginGUI()
        {
            return null;
        }
        public ITMPluginNet GetPluginNet()
        {
            return null;
        }
    }
}