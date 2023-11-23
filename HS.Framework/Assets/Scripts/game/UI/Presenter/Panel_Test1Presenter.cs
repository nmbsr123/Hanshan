using framework;

namespace game.UI.Presenter
{
    public class Panel_Test1Presenter : MainViewPresenter
    {
        public override void OnCreate()
        {
        }

        public override void RefreshUI()
        {
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
            timerid = HS.TimerManager.AddTimer(1, test, 5);
            HS.TimerManager.RemoveTimer(timerid);
            HS.TimerManager.AddFixedTimer(1, test2);
        }

        public override void UnRegister()
        {
        }

        public override void OnDispose()
        {
        }
    }
}