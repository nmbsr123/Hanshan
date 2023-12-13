﻿using UnityEngine;

namespace Framework
{
    public abstract class BasePresenter
    { 
        private View _view = null;
        private bool _isCache = false;
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
        public abstract void OnCreate();
        public abstract void RefreshUI();
        public abstract void InitData();
        public abstract void Register();
        public abstract void UnRegister();
        public abstract void OnDispose();
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