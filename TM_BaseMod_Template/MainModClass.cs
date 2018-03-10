using StudioForge.Engine.Core;
using StudioForge.Engine;
using StudioForge.Engine.Integration;
using StudioForge.TotalMiner;
using StudioForge.TotalMiner.API;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Skyland
{
    class MainModClass : ITMPlugin
    {
        #region ITMPlugin


        void ITMPlugin.WorldSaved(int version)
        {
        }

        void ITMPlugin.UnloadMod()
        {

        }

        void ITMPlugin.PlayerJoined(ITMPlayer player)
        {
        }

        void ITMPlugin.PlayerLeft(ITMPlayer player)
        {
        }

        #endregion

        public static string Path;
        ITMGame game;
        float notifyElapsed;


        public void Initialize(ITMPluginManager mgr, string path)
        {
            Path = path;
        }

        public void InitializeGame(ITMGame game)
        {
            this.game = game;


        }

        public bool HandleInput(ITMPlayer player)
        {
            //handle special mod input keys
            return false;
        }

        public void Update()
        {
            //mods update method
            notifyElapsed += Services.ElapsedTime;
            if (notifyElapsed > 25)
            {
                game.AddNotification("Mod Active", NotifyRecipient.Local);
                notifyElapsed = 0;
            }
        }

        public void Update(ITMPlayer player)
        {
           
        }

        public void Draw(ITMPlayer player, ITMPlayer virtualPlayer)
        {
        }
    }
}
