﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using UnityGameFramework.Runtime;

namespace Trinity
{

    public class TestForm : FGuiForm
    {
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            
            GButton btn = UI.GetChild("BtnBag").asButton;
            btn.onClick.Set(() =>
            {
                Log.Info("点击了按钮");
                GameEntry.UI.OpenUIForm(UIFormId.TestForm2);
            });
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameEntry.UI.CloseUIForm(UIForm);
            }
        }
    }
}

