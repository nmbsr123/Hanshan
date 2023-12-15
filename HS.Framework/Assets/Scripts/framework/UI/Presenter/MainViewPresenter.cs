using System.Collections.Generic;
using Game.Reddot;
using UnityEngine;

namespace Framework
{
    public class MainViewPresenter : BasePresenter
    {
        private bool _isFocus = false;

        public bool IsFocus => _isFocus;
        public bool IsLobby()
        {
            return UIConfig.isLobby;
        }

        public override void OnCreate()
        {
            base.OnCreate();
            FrameworkEventHandler.Event.AddEvent((int)HS_Framework_EventType.OnSetReddotDirty, OnSetReddotDirty);
        }

        public override void Show()
        {
            base.Show();
            Focus();
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
            base.OnDispose();
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
            FrameworkEventHandler.Event.RemoveEvent((int)HS_Framework_EventType.OnSetReddotDirty, OnSetReddotDirty);
        }

        public void Focus()
        {
            Active(true);
            _isFocus = true;
            OnFocus();
            if (_isFocus)
            {
                //先刷新自己的红点
                OnSetReddotDirty();
                //再刷新子界面的红点
                if (_listSubviewPresenters != null)
                {
                    foreach (var subviewPresenter in _listSubviewPresenters)
                    {
                        subviewPresenter.OnSetReddotDirty();
                    }
                }
            }
        }
        
        public void LostFocus()
        {
            if (!_isFocus)
            {
                return;
            }
            Active(false);
            _isFocus = false;
            OnLostFocus();
        }
        
        public virtual void OnFocus()
        {
            
        }
        
        public virtual void OnLostFocus()
        {
            
        }
    }
}