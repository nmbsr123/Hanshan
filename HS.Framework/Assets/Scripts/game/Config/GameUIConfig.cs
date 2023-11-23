using System.Collections.Generic;
using Framework;

namespace Game.Config
{
    public class GameUIConfig
    {
        public enum UIID
        {
            TestPanel1 = 1,
            TestSubview1
        }
        
        public static Dictionary<UIID, UIConfig> DicUIConfigs = new Dictionary<UIID, UIConfig>()
        {
            [UIID.TestPanel1] = new UIConfig()
            {
                uiID = (int)UIID.TestPanel1,
                viewType = ViewType.Panel,
                path = "Assets/Res/OneInOne/UI/Prefab/Panel_Test.prefab",
                isLobby = true
            },
            [UIID.TestSubview1] = new UIConfig()
            {
                uiID = (int)UIID.TestSubview1,
                viewType = ViewType.Subview,
                path = "Assets/Res/OneInOne/UI/Prefab/Subview_Test2.prefab",
            }
        };
    }
}