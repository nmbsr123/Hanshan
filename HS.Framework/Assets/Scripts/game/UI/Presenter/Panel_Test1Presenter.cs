using Framework;
using Game.Config;
using Game.Reddot;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI.Presenter
{
    public class Panel_Test1Presenter : MainViewPresenter
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void RefreshUI()
        {
            HS.UIManager.ShowSubviewPresenter<Subview_Test1>(GetCom<Transform>("Subview_Test1_IGNORE_C").gameObject, this);
            HS.UIManager.LoadSubviewPresenter<Subview_Test2>(GameUIConfig.DicUIConfigs[GameUIConfig.UIID.TestSubview1],
                this, View.UIRoot.transform, isAsync:true);
            // var obj = GetCom<Transform>("ReddotPath1-1-1_C").gameObject;
            // HS.ReddotManager.BindObj(ReddotPathConfig.path1, obj, "1");
            // HS.ReddotManager.BindObj(ReddotPathConfig.path2, GetCom<Transform>("ReddotPath1-1-2_C").gameObject, "1");
            // HS.ReddotManager.BindObj(ReddotPathConfig.path2, GetCom<Transform>("ReddotPath1-2-1_C").gameObject, "2");
            // HS.ReddotManager.BindObj(ReddotPathConfig.path1, GetCom<Transform>("ReddotPath1-2-2_C").gameObject, "2");
            
            BindReddot(string.Format(ReddotPathConfig.path1, "1"), GetCom<Transform>("ReddotPath1-1-1_C").gameObject);
            BindReddot(string.Format(ReddotPathConfig.path2, "1"), GetCom<Transform>("ReddotPath1-1-2_C").gameObject);
            BindReddot(string.Format(ReddotPathConfig.path2, "2"), GetCom<Transform>("ReddotPath1-2-1_C").gameObject);
            BindReddot(string.Format(ReddotPathConfig.path2, "2"), GetCom<Transform>("ReddotPath1-2-2_C").gameObject);
            
            BindReddot(string.Format("11/11{0}", "1"), GetCom<Transform>("ReddotPath1-1_C").gameObject);
            BindReddot(string.Format("11/11{0}", "2"), GetCom<Transform>("ReddotPath1-2_C").gameObject);
            // HS.ReddotManager.BindObj("11/11{0}", GetCom<Transform>("ReddotPath1-1_C").gameObject, "1");
            // HS.ReddotManager.BindObj("11/11{0}", GetCom<Transform>("ReddotPath1-2_C").gameObject, "2");
            
            //HS.ReddotManager.BindObj("11", GetCom<Transform>("ReddotPath1_C").gameObject);

            GetCom<Button>("btn_1_C").onClick.AddListener(() =>
            {
                //HS.ReddotManager.SetDirty(string.Format(ReddotPathConfig.path1, "1"), ReddotCallbackConfig.CheckPath1);
                //HS.ReddotManager.ChangeValue(ReddotPathConfig.path2, ReddotValueType.Has, "2");
                HS.UIManager.ShowMainPresenter<Panel_Test2Presenter>(GameUIConfig.DicUIConfigs[GameUIConfig.UIID.TestPanel2]);
            });
            GetCom<Button>("btn_2_C").onClick.AddListener(() =>
            {
                //HS.ReddotManager.ChangeValue(ReddotPathConfig.path1, ReddotValueType.Has, "2");
                HS.ReddotManager.SetDirty(string.Format(ReddotPathConfig.path1, "1"));
            });
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
        public override void OnFocus()
        {
        }
        

        public override void OnDispose()
        {
            base.OnDispose();
        }
    }
}