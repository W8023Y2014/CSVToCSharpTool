using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Conversation.cs——CSV信息类
/// </summary>
public class Conversation { 

	/// <summary>
	/// 文本ID
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// 是否附带选项
	/// </summary>
	public int ChoAble { get; set; }

	/// <summary>
	/// 半身像方向
	/// </summary>
	public int HalfPhDir { get; set; }

	/// <summary>
	/// 
	/// </summary>
	public string HaflPhAdd { get; set; }

	/// <summary>
	/// 角色名称
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// 是否为结尾句
	/// </summary>
	public int End { get; set; }

	/// <summary>
	/// 对话框类型
	/// </summary>
	public int DialogBox { get; set; }

	/// <summary>
	/// 对话内容
	/// </summary>
	public string Content { get; set; }

	/// <summary>
	/// 配音地址
	/// </summary>
	public string VoAdr { get; set; }

	/// <summary>
	/// 对应表情
	/// </summary>
	public string Emotion { get; set; }

	/// <summary>
	/// 表情坐标
	/// </summary>
	public List<int> EmoPos { get; set; }

	/// <summary>
	/// 选项个数
	/// </summary>
	public int ChoNum { get; set; }

	/// <summary>
	/// 选项
	/// </summary>
	public List<string> Choice { get; set; }

	/// <summary>
	/// 结果
	/// </summary>
	public List<int> Result { get; set; }

	/// <summary>
	/// 结果执行
	/// </summary>
	public List<int> JumpTo { get; set; }

}
