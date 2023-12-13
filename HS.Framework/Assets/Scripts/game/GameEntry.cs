using Framework;
using Framework.LocalStorage;
using Game.Config;
using Game.GameTable;
using Game.Reddot;
using Game.UI.Presenter;
using UnityEngine;

namespace Game
{
    public class GameEntry : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
            //初始化游戏循环
            GameRuner.CreateInstance();
            //资源管理
            ResourceManager.CreateInstance();
            ResourceManager.Instance.Init();
            GameRuner.Instance.RegisterUpdate(AssetBundleManager.Instance);
            //UI管理
            UIManager.CreateInstance();
            UIManager.Instance.Init();
            //配置管理
            GameTableManager.CreateInstance();
            GameTableManager.Instance.Init();
            //本地数据持久化管理
            LocalStorageManager.CreateInstance();
            LocalStorageManager.Instance.Init();
            //计时器管理
            TimerManager.CreateInstance();
            TimerManager.Instance.Init();
            GameRuner.Instance.RegisterUpdate(TimerManager.Instance);
            GameRuner.Instance.RegisterFixUpdate(TimerManager.Instance);
            //红点管理
            ReddotManager.CreateInstance();
            ReddotManager.Instance.Init();
            
            //
            HS.ReddotManager.SetDirty(string.Format(ReddotPathConfig.path1, "1"));
            ReddotManager.Instance.InitReddotNode<int>(string.Format(ReddotPathConfig.path1, "1"), ReddotCallbackConfig.CheckPath1, 100001);
            ReddotManager.Instance.InitReddotNode<int>(string.Format(ReddotPathConfig.path2, "1"), ReddotCallbackConfig.CheckPath1, 100002);
            ReddotManager.Instance.InitReddotNode<int>(string.Format(ReddotPathConfig.path1, "2"), ReddotCallbackConfig.CheckPath1, 100003);
            ReddotManager.Instance.InitReddotNode<int>(string.Format(ReddotPathConfig.path2, "2"), ReddotCallbackConfig.CheckPath1, 100004);
        }

        private void Start()
        {
            HS.UIManager.ShowMainPresenter<Panel_Test1Presenter>(GameUIConfig.DicUIConfigs[GameUIConfig.UIID.TestPanel1], null, false);
            
            // HS.ReddotManager.ChangeValue(ReddotPathConfig.path4, ReddotValueType.Has);
            // HS.ReddotManager.ChangeValue(ReddotPathConfig.path5, ReddotValueType.Has);
        }

        private void Update()
        {
            GameRuner.Instance.Update(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            GameRuner.Instance.FixedUpdate();
        }

        private void LateUpdate()
        {
            GameRuner.Instance.LateUpdate();
        }
    }
    
}