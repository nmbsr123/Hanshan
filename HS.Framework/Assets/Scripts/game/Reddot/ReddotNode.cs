using System.Collections.Generic;
using Game.Extend;
using UnityEngine;

namespace Game.Reddot
{
    public class ReddotNode
    {
        private readonly string _nodeName;
        private List<ReddotNode> _children;
        private ReddotNode _parentNode;
        private bool _isLeaf => _children == null;
        private ReddotValueType _value = ReddotValueType.Null;
        private GameObject _reddotObj = null;

        public ReddotValueType Value => _value;
        public bool IsLeaf => _isLeaf;
        public ReddotNode(string nodeName, ReddotNode parentNode)
        {
            _nodeName = nodeName;
            _parentNode = parentNode;
        }

        public void SetObj(GameObject gameObject)
        {
            _reddotObj = gameObject;
        }

        public void AddChild(ReddotNode childNode)
        {
            if (_children == null)
            {
                _children = new List<ReddotNode>();
            }

            if (_children.Contains(childNode))
            {
                return;
            }
            _children.Add(childNode);
        }

        public void ChangeValue(ReddotValueType valueType = ReddotValueType.Default)
        {
            if (valueType == ReddotValueType.Default)
            {
                ReddotValueType childValue = ReddotValueType.Null; 
                foreach (var childNode in _children)
                {
                    if (childNode.Value == ReddotValueType.Has)
                    {
                        childValue = ReddotValueType.Has;
                        break;
                    }
                }

                _value = childValue;
                UpdateObjActive();
                if (_parentNode == null)
                {
                    return;
                }
                _parentNode.ChangeValue();
            }
            else //如果是叶子节点
            {
                _value = valueType;
                UpdateObjActive();
                if (_parentNode == null)
                {
                    return;
                }
                _parentNode.ChangeValue();
            }
        }

        public void UpdateObjActive()
        {
            if (_reddotObj == null)
            {
                return;
            }
            _reddotObj.ActiveObj(_value == ReddotValueType.Has);
        }
    }

   
}