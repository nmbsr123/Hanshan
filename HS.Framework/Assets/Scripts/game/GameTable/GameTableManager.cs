using cfg;
using framework;
using framework.Log;
using Luban;
using UnityEngine;

namespace game.GameTable
{
    public class GameTableManager : Singleton<GameTableManager>, IManager
    {
        private cfg.Tables _tables = null;
        public void Init()
        {
            _tables = new Tables(LoadByteBuf);
            var item = _tables.TbItem.DataList[1];
            UnityEngine.Debug.LogFormat("item[1]:{0}", item);
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
        
        private static ByteBuf LoadByteBuf(string file)
        {
            var txt = HS.ResourceManager.LoadSync<TextAsset>($"Assets/Res/AllInOne/LubanGen/{file}.bytes").asset as TextAsset;
            if (!txt)
            {
                GameLog.Error("GameTableManager Error");
                return null;
            }
            return new ByteBuf(txt.bytes);
        }
    }
}