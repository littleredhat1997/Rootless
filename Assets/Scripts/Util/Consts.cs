﻿public class Consts
{
    public const int Scene_Main = 0;
    public const int Scene_Game = 1;

    public const string Bg_Music = "music";
    public const string Click_Effect = "click";
    public const string Worm_Effect = "worm";
    public const string Rain_Effect = "rain";
    public const string Wind_Effect = "wind";

    public const string Leaf_Prefab = "Leaf_";
    public const string Sapling_Prefab = "Sapling";
    public const string SmallTree_Prefab = "SmallTree";
    public const string MiddleTree_Prefab = "MiddleTree";
    public const string BigTree_Prefab = "BigTree";
    public const string LoadingScene_Prefab = "LoadingScene";

    public const string Loading_Progress = "LoadingProgress";
    public const string Loading_Bar = "LoadingBar";
    public const string Loading_Icon = "LoadingIcon";

    public const string Tree_Tag = "Tree";
    public const string Ground_Tag = "Ground";

    public const string Rain_Pool = "rain";
    public const string Wind_Pool = "wind";

    public const string Message_Day = "Have a good day!";
    public const string Message_Night = "Have a good night!";
    public const string Message_Good = "Good Debugger!";
    public const string Message_Bad = "Bad Debugger!";
    public const string Message_Worm = "Worms coming!";
    public const string Message_Rain = "Hug the rain!";
    public const string Message_Wind = "Keep the wind!";
    public const string Message_Cool = "Cool!";
    public const string Message_Ouch = "Ouch!";

    ////////// 数值策划 //////////
    public const int Rain_Pool_Max = 50; // 雨对象池最大数量
    public const int Wind_Pool_Max = 50; // 风对象池最大数量

    public const int Start_Rich = 0; // 初始滋润值
    public const int Start_Health = 10; // 初始健康值
    public const int Max_Rich = 10; // 最大滋润值
    public const int Max_Health = 10; // 最大滋润值

    public const int Gravity_Pow = 30; // 重力感应
    public const int Shake_Offset = 3; // 摇动分量
    public const int Shake_Num = 10; // 摇动次数
    public const int Worm_Reward = 2; // 除虫奖金
    public const int Worm_Punish = -5; // 除虫惩罚
    public const int Rain_Reward = 1; // 雨奖励滋润值
    public const int Wind_Punish = -1; // 风惩罚滋润值

    public const float Weather_Fall_Speed = 300.0f; // 下落速度
    public const float Weather_Hide_Time = 0.5f; // 隐藏时间
    public const float Weather_Offset = 600.0f; // 偏移量
    public const float Weather_Angle = 50.0f; // 偏移角

    public const float Worm_Min_Speed = 0.5f; // 虫子最小速度
    public const float Worm_Max_Speed = 1.5f; // 虫子最大速度

    public const float Tree_Grow_Time = 2.0f; // 生长时间
    public const float Tree_Leaf_Time = 2.0f; // 生成时间

    public const float Leaf_ExTime = 2.0f; // 叶子存在时间
    public const float Leaf_Time = 0.5f; // 叶子漂移时间
    public const float Leaf_Offset = 2.0f; // 叶子偏移量
    public const float Leaf_Smooth = 5f; // 叶子平滑值
    public const float Leaf_Speed = 40f; // 叶子速度

    public const float Event_Time = 10.0f; // 事件时间
    public const float Night_Time = 4.0f; // 夜晚时间
    public const float Rain_Time = 0.5f; // 最大下雨间隔
    public const float Wind_Time = 0.5f; // 最大刮风间隔
    public const float Switch_Time = 0.33f; // 背景切换时间
    public const float Message_Time = 1.0f; // 消息显示时间
}
