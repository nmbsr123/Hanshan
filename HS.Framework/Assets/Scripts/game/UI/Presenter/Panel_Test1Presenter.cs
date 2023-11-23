using Framework;
using Game.Config;
using UnityEngine;

namespace Game.UI.Presenter
{
    public class Panel_Test1Presenter : PanelViewPresenter
    {
        public override void OnCreate()
        {
        }

        public override void RefreshUI()
        {
            HS.UIManager.ShowSubviewPresenter<Subview_Test1>(GetCom<Transform>("Subview_Test1_IGNORE_C").gameObject, this);
            HS.UIManager.LoadSubviewPresenter<Subview_Test2>(GameUIConfig.DicUIConfigs[GameUIConfig.UIID.TestSubview1],
                this, View.UIRoot.transform, isAsync:true);
        }

        public override void InitData()
        {
            
        }

        private void test(int timerId)
        {
            GameLog.Log($"timerId {timerId}");
            index++;
            if (index >= 3)
            {
                HS.TimerManager.RemoveTimer(timerid);
            }
        }
        
        private void test2(int timerId)
        {
            GameLog.Error($"timerId {timerId}");
        }

        private int timerid = 0;
        private int index = 0;
        public override void Register()
        {
        }

        public override void UnRegister()
        {
        }

        public override void OnDispose()
        {
            base.OnDispose();
        }
    }
}