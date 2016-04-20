using UnityEngine;
using System.Collections;
using System.Collections.Generic;

////////////////////////////////
/// hero.cs——CSV信息类
////////////////////////////////
public class hero { 

	//ID
	public int ID { get; set; }

	//姓名
	public string Name { get; set; }

	//性别
	public int Sex { get; set; }

	//职业
	public int Job { get; set; }

	//种族
	public int Race { get; set; }

	//头像路径
	public string IconPath { get; set; }

	//半身像路径
	public string BustPath { get; set; }

	//弹幕路径
	public string BarragePath { get; set; }

	//缘分
	public int Fate { get; set; }

	//好感度
	public int Feel { get; set; }

	//等级
	public int Lv { get; set; }

	//受击时长
	public int HuntCD { get; set; }

	//主属性
	public int MainAtt { get; set; }

	//初始力量
	public float Strength { get; set; }

	//力量成长
	public float StrGrow { get; set; }

	//初始生命值
	public int HP { get; set; }

	//初始护甲值
	public float Defense { get; set; }

	//初始敏捷
	public float Agility { get; set; }

	//敏捷成长
	public float AgiGrow { get; set; }

	//初始物攻
	public int PhyAttack { get; set; }

	//基础攻速
	public int BasicsAtcSpeed { get; set; }

	//前后摇时长
	public int FrontCD { get; set; }

	//等待时长
	public int CD { get; set; }

	//攻速
	public int AtcSpeed { get; set; }

	//初始智力
	public float Intellect { get; set; }

	//智力成长
	public float IntGrow { get; set; }

	//初始法攻
	public int MagAttack { get; set; }

	//初始法术抵抗
	public float MagDefense { get; set; }

	//生命回复
	public int HpRecover { get; set; }

	//能量回复
	public int EngRecover { get; set; }

	//物理暴击率
	public float PhyCrit { get; set; }

	//物理暴击倍率
	public float PhyCritPro { get; set; }

	//法术暴击率
	public float MagCrit { get; set; }

	//法术暴击倍率
	public float MagCritPro { get; set; }

	//闪避
	public float Dodge { get; set; }

	//技能循环
	public int[] SkillLoop { get; set; }

	//目标
	public int[] TargetID { get; set; }

	//目标职业
	public int[] TargetJob { get; set; }

	//能量值
	public int Energy { get; set; }

	//移动速度
	public int MoveSpeed { get; set; }

	//技能ID
	public int[] SkillID { get; set; }

	//开放等级
	public int[] OpenLv { get; set; }

	//技能优先级
	public int[] SkillPriority { get; set; }

	//预置物地址
	public int Prefab { get; set; }

}
