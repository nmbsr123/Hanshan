﻿using framework;
using game.GameTable;

namespace game
{
    public class HS
    {
        public static ResourceManager ResourceManager => ResourceManager.Instance;
        public static UIManager UIManager => UIManager.Instance;
        public static EventDispatch GameCommonEvent = new EventDispatch();
        public static GameTableManager GameTableManager => GameTableManager.Instance;
        public static TimerManager TimerManager => TimerManager.Instance;
    }
}