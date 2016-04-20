using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// CharacterStar.cs——CSV信息类
/// </summary>
public class CharacterStar { 

	/// <summary>
	/// ID
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 名称
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 阶级
	/// </summary>
	public int Grade { get; set; }

	/// <summary>
	/// 升阶所需五灵质ID
	/// </summary>
	public List<int> AdvSoulId { get; set; }

	/// <summary>
	/// 升阶所需五灵质数
	/// </summary>
	public List<int> AdvSols { get; set; }

	/// <summary>
	/// 分解所得五灵质ID
	/// </summary>
	public List<int> DecSoulId { get; set; }

	/// <summary>
	/// 分解得出五灵质数
	/// </summary>
	public List<int> DecSols { get; set; }

	/// <summary>
	/// 当前阶级的等级上限
	/// </summary>
	public int LvLimit { get; set; }

	/// <summary>
	/// 当前阶级解锁技能ID
	/// </summary>
	public List<int> SkLearnId { get; set; }

	/// <summary>
	/// 当前阶级基础属性的影响
	/// </summary>
	public float AttriEff { get; set; }

	/// <summary>
	/// 当前阶级基础属性成长的影响
	/// </summary>
	public float AttriGrEff { get; set; }

	/// <summary>
	/// 吞灵质所需四灵质ID
	/// </summary>
	public List<int> EatSolsId { get; set; }

	/// <summary>
	/// 吞灵质数目
	/// </summary>
	public List<int> SolNum { get; set; }

	/// <summary>
	/// 当前阶级吞灵后5属性改变最小值
	/// </summary>
	public int SoulChgMin { get; set; }

	/// <summary>
	/// 当前阶级吞灵后5属性改变最小值
	/// </summary>
	public int SoulChgMax { get; set; }

	/// <summary>
	/// 吞灵质所需五灵质ID
	/// </summary>
	public List<int> EatSolsIdE { get; set; }

	/// <summary>
	/// 吞灵质数目
	/// </summary>
	public List<int> SolNumE { get; set; }

	/// <summary>
	/// 当前阶级吞灵后5属性改变最小值（加入土）
	/// </summary>
	public int SoulChgEMin { get; set; }

	/// <summary>
	/// 当前阶级吞灵后5属性改变最小值（加入土）
	/// </summary>
	public int SoulChgEMax { get; set; }

}
