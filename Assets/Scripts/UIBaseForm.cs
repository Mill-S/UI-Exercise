﻿/*
 *                         Title : "UIFW"项目框架
 *                         主题  ： UI框架基类
 *                         Description :
 *                                     所有窗体类型都要继承于此基类
 *                                     定义了窗体的基本生命周期：显示、隐藏、再显示、冻结
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIFW
{
    public class UIBaseForm : MonoBehaviour
    {
        private UIType _CurrentUIType = null;

        public UIType CurrentUIType
        {
            get { return _CurrentUIType; }
            set { _CurrentUIType = value; }
        }

        public virtual void Display()
        {
            this.gameObject.SetActive(true);
        }

        public virtual void Hiding()
        {
            this.gameObject.SetActive(false);
        }

        public virtual void ReDisplay()
        {
            this.gameObject.SetActive(true);
        }

        public virtual void Freeze()
        {
            this.gameObject.SetActive(false);
        }
    }
}