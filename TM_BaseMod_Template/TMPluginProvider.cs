using StudioForge.TotalMiner.API;

namespace ProjectNameSpace
{
    class TMPluginProvider : ITMPluginProvider
    {
        public ITMPlugin GetPlugin()
        {
            return new MainModClass();
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