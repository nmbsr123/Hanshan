using System;
using System.Collections.Generic;
using UnityEngine;
namespace Framework
{
    public class View : IView
    {
        private GameObject _uiRoot = null;
        private Dictionary<string, NodeBind> _dicNodeBind = new Dictionary<string, NodeBind>();
        private bool _isInit = false;
        public GameObject UIRoot
        {
            get
            {
                if (_uiRoot == null)
                {
                    GameLog.Error("_uiRoot is null");
                    return null;
                }

                return _uiRoot;
            }
            set => _uiRoot = value;
        }
        
        public void InitNodeBind()
        {
            if (_isInit)
            {
                return;
            }
            if (_uiRoot == null)
            {
                GameLog.Error("_uiRoot's asset is null");
                return;
            }

            Dictionary<int, bool> dicIgnoreCache = new Dictionary<int, bool>(5);
            var coms = _uiRoot.GetComponentsInChildren<NodeBind>();
            foreach (var com in coms)
            {
                if (com.transform.parent.GetComponent<IgnoreChildrenNode>())
                {
                    dicIgnoreCache.Add(com.transform.GetInstanceID(), true);
                    continue;
                }
                if (dicIgnoreCache.ContainsKey(com.transform.parent.GetInstanceID()))
                {
                    continue;
                }
                
                _dicNodeBind.Add(com.name, com);
            }

            _isInit = true;
        }

        public void SetCanvasOrder(int order)
        {
            if (_uiRoot == null)
            {
                return;
            }

            var canvas = _uiRoot.GetComponent<Canvas>();
            if (canvas == null)
            {
                GameLog.Error("canvas is null");
                return;
            }

            canvas.sortingOrder = order;
        }

        public T GetCom<T>(string nodeName) where T : Component
        {
            if (_dicNodeBind.ContainsKey(nodeName))
            {
                return _dicNodeBind[nodeName].GetCom<T>();
            }
            else
            {
                GameLog.Error("node not exits : " + nodeName);
                return null;
            }
        }

        public bool IsActive()
        {
            if (_uiRoot == null)
            {
                return false;
            }

            return _uiRoot.activeSelf;
        }

        public void Active(bool bActive)
        {
            if (_uiRoot == null)
            {
                return;
            }

            if (_uiRoot.activeSelf == bActive)
            {
                return;
            }
            _uiRoot.SetActive(bActive);
        }

        public bool IsLastSlibingIndex()
        {
            if (_uiRoot == null)
            {
                return false;
            }
            return _uiRoot.transform.GetSiblingIndex() == _uiRoot.transform.parent.childCount - 1;
        }
    }
}