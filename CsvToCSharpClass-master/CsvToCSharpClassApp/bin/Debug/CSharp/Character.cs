using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Character.cs——CSV信息类
/// </summary>
public class Character { 

	/// <summary>
	/// ID
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 名称
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 性别
	/// </summary>
	public int Gender { get; set; }

	/// <summary>
	/// 种族
	/// </summary>
	public int Race { get; set; }

	/// <summary>
	/// 职业
	/// </summary>
	public int Occupation { get; set; }

	/// <summary>
	/// 初始精
	/// </summary>
	public int Vigour { get; set; }

	/// <summary>
	/// 精极限值
	/// </summary>
	public int VigourLim { get; set; }

	/// <summary>
	/// 精成长
	/// </summary>
	public float VigGrowth { get; set; }

	/// <summary>
	/// 初始气
	/// </summary>
	public int Pep { get; set; }

	/// <summary>
	/// 气极限值
	/// </summary>
	public int PepLim { get; set; }

	/// <summary>
	/// 气成长
	/// </summary>
	public float PepGrowth { get; set; }

	/// <summary>
	/// 初始神
	/// </summary>
	public int Spirit { get; set; }

	/// <summary>
	/// 神极限值
	/// </summary>
	public int SpiritLim { get; set; }

	/// <summary>
	/// 神成长
	/// </summary>
	public float SpGrowth { get; set; }

	/// <summary>
	/// 初始武
	/// </summary>
	public int Force { get; set; }

	/// <summary>
	/// 武极限值
	/// </summary>
	public int ForceLim { get; set; }

	/// <summary>
	/// 武成长
	/// </summary>
	public float ForGrowth { get; set; }

	/// <summary>
	/// 初始智
	/// </summary>
	public int Intel { get; set; }

	/// <summary>
	/// 智极限值
	/// </summary>
	public int IntelLim { get; set; }

	/// <summary>
	/// 智成长
	/// </summary>
	public float IntGrowth { get; set; }

	/// <summary>
	/// 血量_精转化系数
	/// </summary>
	public float HpConv { get; set; }

	/// <summary>
	/// 采集_精转化系数
	/// </summary>
	public float ColConv { get; set; }

	/// <summary>
	/// 气罩量_气转化系数
	/// </summary>
	public float FieConv { get; set; }

	/// <summary>
	/// 神_战后气罩回复系数
	/// </summary>
	public float FieReConv { get; set; }

	/// <summary>
	/// 神_魔法回复系数
	/// </summary>
	public float ManaReConv { get; set; }

	/// <summary>
	/// 物攻_武转化系数
	/// </summary>
	public float AttConv { get; set; }

	/// <summary>
	/// 法攻_武转化系数
	/// </summary>
	public float MagConv { get; set; }

	/// <summary>
	/// 造物_智转化率
	/// </summary>
	public float CreConv { get; set; }

	/// <summary>
	/// 锻造_智转化率
	/// </summary>
	public float ForgConv { get; set; }

	/// <summary>
	/// 头像路径
	/// </summary>
	public string IconPath { get; set; }

	/// <summary>
	/// 半身像路径
	/// </summary>
	public string BustPath { get; set; }

	/// <summary>
	/// 弹幕路径
	/// </summary>
	public string BarragePath { get; set; }

	/// <summary>
	/// 攻速
	/// </summary>
	public int AtkSpeed { get; set; }

	/// <summary>
	/// 移动速度
	/// </summary>
	public int MoveSpeed { get; set; }

	/// <summary>
	/// 气罩真空状态恢复时间
	/// </summary>
	public int NoneFidTime { get; set; }

	/// <summary>
	/// 气罩回复速度
	/// </summary>
	public float FidReSp { get; set; }

	/// <summary>
	/// 技能ID
	/// </summary>
	public List<int> SkillID { get; set; }

	/// <summary>
	/// 预置物
	/// </summary>
	public int Prefab { get; set; }

}
