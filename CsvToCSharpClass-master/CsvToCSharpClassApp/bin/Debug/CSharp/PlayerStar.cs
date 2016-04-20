using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// PlayerStar.cs——CSV信息类
/// </summary>
public class PlayerStar { 

	/// <summary>
	/// ID
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 名称
	/// </summary>
	public string Name { get; set; }

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
	/// 当前阶级吞灵后5属性改变最大值
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
	/// 当前阶级吞灵后5属性改变最大值（加入土）
	/// </summary>
	public int SoulChgEMax { get; set; }

}
