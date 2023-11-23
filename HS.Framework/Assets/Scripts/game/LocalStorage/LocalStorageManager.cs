using Game;
using Game.Config;
using UnityEngine;

namespace Framework.LocalStorage
{
    public class LocalStorageManager : Singleton<LocalStorageManager>, IManager
    {
        private string _userid = string.Empty;
        
        public void Init()
        {
            HS.GameCommonEvent.AddEvent<string>((int)HS_Game_EventType.OnGetUserId, SetUserId);
        }

        public void Dispose()
        {
            HS.GameCommonEvent.RemoveEvent<string>((int)HS_Game_EventType.OnGetUserId, SetUserId);
        }
        
        private void SetUserId(string userid)
        {
            _userid = userid;
        }

        private string GetUniqueKey(string key)
        {
            return $"{_userid}/key";
        }

        public int GetInt(string key, int defaultValue)
        {
            return PlayerPrefs.GetInt(GetUniqueKey(key), defaultValue);
        }
        
        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(GetUniqueKey(key), value);
        }
        
        //todo
    }
}