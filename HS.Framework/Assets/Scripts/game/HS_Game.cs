using Framework;
using Game.GameTable;
using Game.Reddot;

namespace Game
{
    public class HS
    {
        public static ResourceManager ResourceManager => ResourceManager.Instance;
        public static UIManager UIManager => UIManager.Instance;
        public static EventDispatch GameCommonEvent = new EventDispatch();
        public static GameTableManager GameTableManager => GameTableManager.Instance;
        public static TimerManager TimerManager => TimerManager.Instance;
        public static ReddotManager ReddotManager => ReddotManager.Instance;
    }
}