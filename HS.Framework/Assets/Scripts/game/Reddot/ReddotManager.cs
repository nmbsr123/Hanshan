using System.Collections.Generic;
using System.Text;
using Framework;
using UnityEngine;

namespace Game.Reddot
{
    public enum ReddotValueType
    {
        Default = -1,
        Null,
        Has
    }
    
    public class ReddotManager : Singleton<ReddotManager>, IManager
    {
        private Dictionary<string, ReddotNode> _dicAllNode;
        private const char SPLIT_TAG = '/';
        private StringBuilder _sb;
        private ReddotNode _rootNode;
        
        public void Init()
        {
            _dicAllNode = new Dictionary<string, ReddotNode>();
            _sb = new StringBuilder();
            _rootNode = new ReddotNode("Root", null);
        }

        public void ChangeValue(string path, ReddotValueType valueType)
        {
            if (valueType == ReddotValueType.Default)
            {
                GameLog.Error("valueType Error");
                return;
            }
            var node = GetOrAddNode(path);
            if (node == null)
            {
                return;
            }

            if (!node.IsLeaf)
            {
                GameLog.Error("非叶子节点");
                return;
            }
            node.ChangeValue(valueType);
        }

        public void ChangeValue(string path, ReddotValueType valueType, params object[] args)
        {
            var targetPath = string.Format(path, args);
            ChangeValue(targetPath, valueType);
        }

        public void BindObj(string path, GameObject gameObject)
        {
            var node = GetOrAddNode(path);
            if (node == null)
            {
                return;
            }

            if (gameObject == null)
            {
                GameLog.Error("gameObject is null");
                return;
            }
            
            node.SetObj(gameObject);
            node.UpdateObjActive();
        }
        
        public void BindObj(string path, GameObject gameObject, params object[] args)
        {
            var targetPath = string.Format(path, args);
            var node = GetOrAddNode(targetPath);
            if (node == null)
            {
                return;
            }

            if (gameObject == null)
            {
                GameLog.Error("gameObject is null");
                return;
            }
            
            node.SetObj(gameObject);
            node.UpdateObjActive();
        }

        private ReddotNode GetOrAddNode(string path)
        {
            if (_dicAllNode.TryGetValue(path, out var targetNode))
            {
                return targetNode;
            }
            else
            {
                if (path[path.Length - 1] == SPLIT_TAG)
                {
                    GameLog.Error($"路径配置错误，不能以{SPLIT_TAG}结尾");
                    return null;
                }

                _sb.Clear();
                ReddotNode curNode = _rootNode;
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == SPLIT_TAG)
                    {
                        var nodeName = _sb.ToString();
                        if (_dicAllNode.TryGetValue(nodeName, out var childNode))
                        {
                            curNode = childNode;
                        }
                        else
                        {
                            //创建
                            childNode = new ReddotNode(nodeName, curNode);
                            curNode.AddChild(childNode);
                            _dicAllNode.Add(nodeName, childNode);
                            curNode = childNode;
                        }
                        _sb.Append(SPLIT_TAG);
                    }
                    else
                    {
                        _sb.Append(path[i]);
                    }
                }
                var leafNode = new ReddotNode(path, curNode);
                curNode.AddChild(leafNode);
                _dicAllNode.Add(path, leafNode);
                return leafNode;
            }
        }

        public void Dispose()
        {
            _dicAllNode.Clear();
            _dicAllNode = null;
            _rootNode = null;
            _sb = null;
        }
    }
}