////------------------------------------------------------------------------------
//// <auto-generated>
////     此代码由工具生成。
////     运行时版本:4.0.30319.17929
////
////     对此文件的更改可能会导致不正确的行为，并且如果
////     重新生成代码，这些更改将会丢失。
//// </auto-generated>
////------------------------------------------------------------------------------
//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//using GameDefine;
//using JT.FWW.Tools;
//using BlGame.GameData;
//using BlGame.GameEntity;


//[yaz]屏蔽，代码好像没用到

//namespace BlGame.Effect
//{
//        public class LabelJumpEffect:IEffect
//        {
//                public Color mColor
//        {
//            set;
//            get;
//        }
//        public string content
//        {
//            set;
//            get;
//        }
//        public Vector3 posInWorld
//        {
//            set;
//            get;
//        }
//        private UILabel labelContent
//        {
//            get;
//            set;
//        }
//                public static Color shangColor = Color.yellow;
//                public static Color huiColor = Color.green;
//                public static Color baojiColor = Color.red;
//                public static Color mpColor = Color.blue;
//                public enum LabelJumpType
//                {
//                    None,
//                    LJT_Shang,	// 血
//                    LJT_MP,
//                    LJT_Heal,
//                }
//                public LabelJumpEffect ()
//                {
//                }
//                public override void OnLoadComplete()
//                {
//                    labelContent = obj.GetComponentInChildren<UILabel>();
//                    labelContent.text = content;
//                    labelContent.color = mColor;
//                    labelContent.transform.localScale = new Vector3(2.0f,2.0f,2.0f);
//                    obj.transform.parent = GameMethod.GetUiCamera.transform;
//                    obj.transform.position = GameMethod.SceneToUIPos(posInWorld);
//                    obj.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
//                }
//                public override void Update ()
//                {
//                    base.UpdateTimeCount ();
//                    obj.transform.position = GameMethod.SceneToUIPos(posInWorld);
//                    Vector3 pos = labelContent.transform.localPosition;
//                    pos.y = pos.y + Time.deltaTime * 30.0f;
//                    labelContent.transform.localPosition = pos;
//                    if(elapseTime != 0.0f)
//                    {
//                        Color c = labelContent.color;
//                        c.a = 1.5f - (elapseTime - timeCounter) / elapseTime;
//                        labelContent.color = c;
//                    }
//                    if(timeCounter <= 0.0f)
//                    {
//                        isRemove = true;
//                    }
//                }
//        }
//}

