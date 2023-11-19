using System;
using System.Collections.Generic;
using framework;
using framework.Resource;
using framework.UI;
using game.Config;
using game.GameTable;
using game.UI.Presenter;
using UnityEngine;

namespace game
{
    public class GameEntry : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
            GameRuner.CreateInstance();
            ResourceManager.CreateInstance();
            ResourceManager.Instance.Init();
            GameRuner.Instance.RegisterUpdate(AssetBundleManager.Instance);
            UIManager.CreateInstance();
            UIManager.Instance.Init();
            GameTableManager.CreateInstance();
            GameTableManager.Instance.Init();
        }

        private void Start()
        {
            HS.UIManager.ShowMainPresenter<Panel_Test1Presenter>((int)GameUIConfig.UIID.TestPanel1, GameUIConfig.DicUIConfigs[GameUIConfig.UIID.TestPanel1], null, false);
        }

        private void Update()
        {
            GameRuner.Instance.Update(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            GameRuner.Instance.FixedUpdate();
        }

        private void LateUpdate()
        {
            GameRuner.Instance.LateUpdate();
        }
    }
    
}