using Framework;
using Game.Config;
using UnityEngine.UI;

namespace Game.UI
{
    public class Panel_Test2Presenter : MainViewPresenter
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void RefreshUI()
        {
        }

        public override void InitData()
        {
        }
        
        public override void Register()
        {
            GetCom<Button>("btn_1_C").onClick.AddListener(() =>
            {
                HS.ReddotManager.SetDirty(string.Format(ReddotPathConfig.path1, "1"));
                //HS.ReddotManager.ChangeValue(ReddotPathConfig.path2, ReddotValueType.Has, "2");
            });
            GetCom<Button>("btn_2_C").onClick.AddListener(() =>
            {
                //HS.ReddotManager.ChangeValue(ReddotPathConfig.path1, ReddotValueType.Has, "2");
                HS.UIManager.CloseCur();
            });
        }

        public override void UnRegister()
        {
        }

        public override void OnDispose()
        {
        }
    }
}
