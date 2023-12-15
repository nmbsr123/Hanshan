using System.Collections.Generic;
using Game.Reddot;
using UnityEngine;

namespace Framework
{
    public abstract class BasePresenter
    { 
        private View _view = null;
        private bool _isCache = false;
        private Dictionary<string, ReddotNode> _dicReddotNodes = null;
        protected List<SubviewPresenter> _listSubviewPresenters = null;

        public UIConfig UIConfig { get; set; }
        public LoaderHandler Handler { get; set; }
        public View View
        {
            get
            {
                if (_view == null)
                {
                    GameLog.Error("view is null");
                    return null;
                }

                return _view;
            }
            set => _view = value;
        }
        
        public T GetCom<T>(string nodeName) where T : Component
        {
            return View.GetCom<T>(nodeName);
        }

        public virtual void OnCreate()
        {
            _dicReddotNodes = new Dictionary<string, ReddotNode>();
        }

        public abstract void RefreshUI();
        public abstract void InitData();
        public abstract void Register();
        public abstract void UnRegister();

        public virtual void OnDispose()
        {
            if (_dicReddotNodes != null)
            {
                _dicReddotNodes.Clear();
                _dicReddotNodes = null;
            }
        }

        private BaseUIParam _uiParam = null;

        public bool IsActive()
        {
            if (_view == null)
            {
                return false;
            }

            return _view.IsActive();
        }

        public bool IsLastSlibingIndex()
        {
            if (_view == null)
            {
                return false;
            }
            return _view.IsLastSlibingIndex();
        }
        
        public void SetAsLastSlibingIndex()
        {
            if (_view == null)
            {
                return;
            }
            _view.SetAsLastSlibingIndex();
        }

        public void Active(bool bActive)
        {
            if (_view == null)
            {
                return;
            }
            _view.Active(bActive);
        }

        public void SetParam(BaseUIParam param)
        {
            _uiParam = param;
        }

        protected T GetParam<T>() where T : BaseUIParam
        {
            return _uiParam as T;
        }

        public virtual void Show()
        {
            if (_view == null)
            {
                return;
            }
            _view.InitNodeBind();
            InitData();
            RefreshUI();
            Register();
        }
        
        /// <summary>
        /// 监听红点设置脏位事件，如果当前Focus界面关联的红点包含脏位红点或者是脏位红点的父节点，那么立即刷新脏位红点
        /// </summary>
        /// <param name="dirtyPath"></param>
        public void OnSetReddotDirty()
        {
            if (_dicReddotNodes == null)
            {
                return;
            }
            //遍历关联的红点的子节点是否需要刷新
            foreach (var keyVal in _dicReddotNodes)
            {
                ReddotManager.Instance.TraverseRefreshTree(keyVal.Value);
            }
        }
        
        public void BindReddot(string path, GameObject gameObject)
        {
            if (gameObject == null)
            {
                return;
            }

            if (_dicReddotNodes.TryGetValue(path, out var reddotNode))
            {
                reddotNode.SetObj(gameObject);
            }
            else
            {
                ReddotManager.Instance.BindObj(path, gameObject);
                reddotNode = ReddotManager.Instance.GetNode(path);
                _dicReddotNodes.Add(path, reddotNode);
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
        
        public void Dispose()
        {
            OnDispose();
            UnRegister();
            if (!_isCache)
            {
                if (_view != null && _view.UIRoot != null)
                {
                    GameObject.Destroy(_view.UIRoot);
                }
                if (Handler != null)
                {
                    Handler.Unload();
                }

                _view = null;
            }
        }
    }
}