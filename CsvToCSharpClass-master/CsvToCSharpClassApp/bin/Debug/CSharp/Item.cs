using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Item.cs——CSV信息类
/// </summary>
public class Item { 

	/// <summary>
	/// id
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 名称
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 类型
	/// </summary>
	public int Type { get; set; }

	/// <summary>
	/// 是否能堆叠
	/// </summary>
	public int Stackable { get; set; }

	/// <summary>
	/// 贵重等级
	/// </summary>
	public int Grade { get; set; }

	/// <summary>
	/// 说明
	/// </summary>
	public string Description { get; set; }

	/// <summary>
	/// 是否可卖
	/// </summary>
	public int Sellable { get; set; }

	/// <summary>
	/// 卖出价格
	/// </summary>
	public int Price { get; set; }

	/// <summary>
	/// 脚本ID
	/// </summary>
	public int ScriptId { get; set; }

}
