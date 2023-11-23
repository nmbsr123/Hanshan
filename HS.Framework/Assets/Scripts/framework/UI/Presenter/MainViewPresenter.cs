using System.Collections.Generic;

namespace Framework
{
    public class MainViewPresenter : BasePresenter
    {
        private List<SubviewPresenter> _listSubviewPresenters = null;

        public bool IsLobby()
        {
            return UIConfig.isLobby;
        }

        public override void OnCreate()
        {
        }

        public override void RefreshUI()
        {
        }

        public override void InitData()
        {
        }

        public override void Register()
        {
        }

        public override void UnRegister()
        {
        }

        public override void OnDispose()
        {
            if (_listSubviewPresenters != null)
            {
                foreach (var subviewPresenter in _listSubviewPresenters)
                {
                    //如果是动态加载的子界面
                    if (subviewPresenter.UIConfig != null)
                    {
                        UIManager.Instance.RemoveLoaderHandler(subviewPresenter.UIConfig.uiID);
                    }
                    subviewPresenter.Dispose();
                }
                _listSubviewPresenters.Clear();
                _listSubviewPresenters = null;
            }
        }

        public void AddSubview(SubviewPresenter subviewPresenter)
        {
            if (_listSubviewPresenters == null)
            {
                _listSubviewPresenters = new List<SubviewPresenter>();
            }
            _listSubviewPresenters.Add(subviewPresenter);
        }
    }
}