using System;
using System.Collections.Generic;
using System.Text;
using Framework;

namespace Game.Reddot
{
    
    
    public class ReddotNode
    {
        private readonly string _nodeName;
        private List<ReddotNode> _children;
        private ReddotNode _parentNode;
        private bool _isLeaf => _children == null;

        public ReddotNode(string nodeName, ReddotNode parentNode)
        {
            _nodeName = nodeName;
            _parentNode = parentNode;
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

        public ReddotNode GetOrAddNode(string path)
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
                        if (!_dicAllNode.ContainsKey(nodeName))
                        {
                            //创建
                            var childNode = new ReddotNode(nodeName, curNode);
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
        }
    }
}