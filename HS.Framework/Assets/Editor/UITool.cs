
using System.IO;
using System.Text;
using Framework;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UITool : EditorWindow
{
    private const string MAIN_PRESENTER_TEMP =
        @"using Framework;

namespace Game.UI
{
    public class @ClassName : @BaseType
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
        
        public override void Register()
        {
        }

        public override void UnRegister()
        {
        }

        public override void OnFocus()
        {
        }

        public override void OnDispose()
        {
            base.OnDispose();
        }
    }
}
";
    
    private const string NODE_BING_TAG = "_C";
    private const string NODE_IGNORE_TAG = "_IGNORE";
    
    /// <summary>
    /// 做两件事 1.节点名字后缀为_C挂载NodeBind组件 2.节点名字含有_IGNORE挂载IgnoreNodeBind组件
    /// </summary>
    [MenuItem("GameObject/UITool/UINodeBind")]
    public static void UINodeBind()
    {
        var stage = PrefabStageUtility.GetCurrentPrefabStage();
        if (stage == null)
        {
            GameLog.Error("请打开prefab进入编辑模式");
            return;
        }
        
        var curObj = stage.prefabContentsRoot;
        var children  = curObj.GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            if (child.name.EndsWith(NODE_BING_TAG))
            {
                if (!child.GetComponent<NodeBind>())
                {
                    child.AddComponent<NodeBind>();
                }
            }
            else
            {
                var com = child.GetComponent<NodeBind>();
                if (com != null)
                {
                    DestroyImmediate(com);
                }
            }

            if (child.name.Contains(NODE_IGNORE_TAG))
            {
                if (!child.GetComponent<IgnoreChildrenNode>())
                {
                    child.AddComponent<IgnoreChildrenNode>();
                }
            }
            else
            {
                var com = child.GetComponent<IgnoreChildrenNode>();
                if (com != null)
                {
                    DestroyImmediate(com);
                }
            }
        }
        GameLog.Log("节点绑定成功");
    }

    private static string _savePath = Path.Combine(Application.dataPath, "Scripts/Game/UI/Presenter");
    
    [MenuItem("GameObject/UITool/CreateMainPresenter")]
    public static void CreatePanelPresenter()
    {
        CreateMainPresenter(ViewType.Panel);
    }
    
    [MenuItem("GameObject/UITool/CreateSubviewPresenter")]
    public static void CreateSubviewPresenter()
    {
        CreateMainPresenter(ViewType.Subview);
    }
    
    private static void CreateMainPresenter(ViewType viewType)
    {
        var stage = PrefabStageUtility.GetCurrentPrefabStage();
        if (stage == null)
        {
            GameLog.Error("请打开prefab进入编辑模式");
            return;
        }

        var curObj = stage.prefabContentsRoot;
        var presenterName = curObj.name;
        var presenterContent = MAIN_PRESENTER_TEMP.Replace("@ClassName", presenterName);
        if (viewType == ViewType.Panel)
        {
            presenterContent = presenterContent.Replace("@BaseType", "MainViewPresenter");
        }
        else if (viewType == ViewType.Subview)
        {
            presenterContent = presenterContent.Replace("@BaseType", "SubviewPresenter");
        }
        _savePath = EditorUtility.SaveFolderPanel("请选择保存路径", _savePath, "");
        var savePath = Path.Combine(_savePath, $"{presenterName}Presenter.cs");
        if (!File.Exists(savePath))
        {
            File.WriteAllText(savePath, presenterContent, Encoding.UTF8);
            GameLog.Log("cs文件生成成功");
            AssetDatabase.Refresh();
        }
        else
        {
            GameLog.Error($"{presenterName}.cs 已存在");
        }
    }

}
