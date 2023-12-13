using System.Collections.Generic;
using Game.Reddot;
using UnityEngine;

namespace Framework
{
    public class MainViewPresenter : BasePresenter
    {
        private List<SubviewPresenter> _listSubviewPresenters = null;
        private bool _isFocus = false;
        private Dictionary<string, ReddotNode> _dicReddotNodes = null;

        public bool IsFocus => _isFocus;
        public bool IsLobby()
        {
            return UIConfig.isLobby;
        }

        public override void OnCreate()
        {
            FrameworkEventHandler.Event.AddEvent((int)HS_Framework_EventType.OnSetReddotDirty, OnSetReddotDirty);
            _dicReddotNodes = new Dictionary<string, ReddotNode>();
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

            if (_dicReddotNodes != null)
            {
                _dicReddotNodes.Clear();
                _dicReddotNodes = null;
            }
            FrameworkEventHandler.Event.RemoveEvent((int)HS_Framework_EventType.OnSetReddotDirty, OnSetReddotDirty);
        }

        public void Focus()
        {
            Active(true);
            _isFocus = true;
            OnFocus();
            OnSetReddotDirty();
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

        public void AddSubview(SubviewPresenter subviewPresenter)
        {
            if (_listSubviewPresenters == null)
            {
                _listSubviewPresenters = new List<SubviewPresenter>();
            }
            _listSubviewPresenters.Add(subviewPresenter);
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

        /// <summary>
        /// 监听红点设置脏位事件，如果当前Focus界面关联的红点包含脏位红点或者是脏位红点的父节点，那么立即刷新脏位红点
        /// </summary>
        /// <param name="dirtyPath"></param>
        private void OnSetReddotDirty()
        {
            if (!_isFocus)
            {
                return;
            }
            //遍历关联的红点的子节点是否需要刷新
            foreach (var keyVal in _dicReddotNodes)
            {
                ReddotManager.Instance.TraverseRefreshTree(keyVal.Value);
            }
        }
        
    }
}