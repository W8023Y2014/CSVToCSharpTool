using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// RoleInfo.cs——CSV信息类
/// </summary>
public class RoleInfo { 

	/// <summary>
	/// 资源ID
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 人物模型动画名称
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 人物模型动画路径
	/// </summary>
	public string Path { get; set; }

	/// <summary>
	/// 资源类型
	/// </summary>
	public int Type { get; set; }

	/// <summary>
	/// 资源描述
	/// </summary>
	public string Information { get; set; }

	/// <summary>
	/// 面向
	/// </summary>
	public int OriginFaceTo { get; set; }

}
