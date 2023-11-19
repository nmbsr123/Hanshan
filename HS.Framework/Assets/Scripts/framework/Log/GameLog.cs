﻿using UnityEngine;

namespace framework.Log
{
    public class GameLog
    {
        public static void Log(string str)
        {
            Debug.Log(str);
        }
        
        public static void Error(string str)
        {
            Debug.LogError(str);
        }
    }
}